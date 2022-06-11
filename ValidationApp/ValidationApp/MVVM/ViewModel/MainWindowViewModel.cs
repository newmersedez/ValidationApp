using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using MVVM.Core.Command;
using MVVM.Core.ViewModel;
using Proto;
using ValidationApp.Client;
using ValidationApp.Context;

namespace ValidationApp.MVVM.ViewModel;

public sealed class MainWindowViewModel : ViewModelBase
{
    public SolidColorBrush FullnameBorderBrush { get; set; } = new SolidColorBrush(Colors.Gray);
    public SolidColorBrush PassportBorderBrush { get; set; } = new SolidColorBrush(Colors.Gray);
    public SolidColorBrush BirthdayBorderBrush { get; set; } = new SolidColorBrush(Colors.Gray);
    public SolidColorBrush PhoneBorderBrush { get; set; } = new SolidColorBrush(Colors.Gray);
    public SolidColorBrush AddressBorderBrush { get; set; } = new SolidColorBrush(Colors.Gray);
    public SolidColorBrush EmailBorderBrush { get; set; } = new SolidColorBrush(Colors.Gray);
    
    private ValidationClient _validation_client;
    private ValidationReply _validation_reply;
    private Contact _contact_to_validate=new Contact(); 
    public ObservableCollection<Contact> Contacts { get; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public string Patronymic { get; set; }
    public string PassportNumber { get; set; }
    public string BirthdayDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    private RelayCommandAsync _command_validate_contact;
    public RelayCommandAsync CommandValidateContact
    {
        get {return _command_validate_contact = new RelayCommandAsync(validateContact_execute, validateContact_canExecute, (ex) => {return;});}
    }

    public MainWindowViewModel()
    {
        Contacts = new ObservableCollection<Contact>();
        _validation_client=new ValidationClient();

        SolidColorBrush FullnameBorderBrush = new SolidColorBrush(Colors.Gray);
        SolidColorBrush PassportBorderBrush = new SolidColorBrush(Colors.Gray);
        SolidColorBrush BirthdayBorderBrush = new SolidColorBrush(Colors.Gray);
        SolidColorBrush PhoneBorderBrush = new SolidColorBrush(Colors.Gray);
        SolidColorBrush AddressBorderBrush = new SolidColorBrush(Colors.Gray);
        SolidColorBrush EmailBorderBrush = new SolidColorBrush(Colors.Gray);
    }

    private async Task validateContact_execute()
    {
        FullnameBorderBrush.Color = Colors.Gray;
        PassportBorderBrush.Color = Colors.Gray;
        BirthdayBorderBrush.Color = Colors.Gray;
        PhoneBorderBrush.Color = Colors.Gray;
        AddressBorderBrush.Color = Colors.Gray;
        EmailBorderBrush.Color = Colors.Gray;
        
        _contact_to_validate.Lastname=Lastname;
        _contact_to_validate.Firstname=Firstname;
        _contact_to_validate.Patronymic=Patronymic;
        _contact_to_validate.PassportNumber=PassportNumber;
        _contact_to_validate.BirthdayDate=BirthdayDate;
        _contact_to_validate.PhoneNumber=PhoneNumber;
        _contact_to_validate.Email=Email;
        _contact_to_validate.Address=Address;
        
        _validation_reply=await _validation_client.validate(_contact_to_validate);
        
        if(_validation_reply.Result.Result)
            Application.Current.Dispatcher?.Invoke(()=> Contacts.Add(_contact_to_validate));
        else
        {
            var serverReply = _validation_reply.Result.Info.Split(';');
            foreach (var reply in serverReply)
            {
                var reply_list = reply.Split(' ');
                if (reply_list[1] == "false")
                {
                    switch (reply_list[0])
                    {
                        case "Fullname ":
                            FullnameBorderBrush.Color = Colors.Firebrick;
                            MessageBox.Show("Ошибка в поле \"ФИО\"");
                            break;
                        case "Phone":
                            PhoneBorderBrush.Color = Colors.Firebrick;
                            MessageBox.Show("Ошибка в поле \"Номер телефона\"");
                            break;
                        case "Passport":
                            PassportBorderBrush.Color = Colors.Firebrick;
                            MessageBox.Show("Ошибка в поле \"Номер паспорта\"");
                            break;
                        case "Email":
                            EmailBorderBrush.Color = Colors.Firebrick;
                            MessageBox.Show("Ошибка в поле \"Адрес электронной почты\"");
                            break;
                        case "Date":
                            BirthdayBorderBrush.Color = Colors.Firebrick;
                            MessageBox.Show("Ошибка в поле \"День рождения\"");
                            break;
                        case "Address":
                            AddressBorderBrush.Color = Colors.Firebrick;
                            MessageBox.Show("Ошибка в поле \"Адрес проживания\"");
                            break;
                    }
                }
            }
        }
    }
    private bool validateContact_canExecute(object parameter)
    {
        if(string.IsNullOrEmpty(Lastname) || string.IsNullOrEmpty(Firstname) || string.IsNullOrEmpty(Patronymic)
           || string.IsNullOrEmpty(PhoneNumber) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Address)
           || string.IsNullOrEmpty(PassportNumber) || string.IsNullOrEmpty(BirthdayDate))
            return false;

        return true;
    }
}