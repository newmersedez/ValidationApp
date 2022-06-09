using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MVVM.Core.Command;
using MVVM.Core.ViewModel;
using Proto;
using ValidationApp.Client;
using ValidationApp.Context;

namespace ValidationApp.MVVM.ViewModel;

public sealed class MainWindowViewModel : ViewModelBase
{
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
        get {return _command_validate_contact??=new RelayCommandAsync(validateContact_execute, validateContact_canExecute, (ex) => {return;});}
    }

    public MainWindowViewModel()
    {
        Contacts = new ObservableCollection<Contact>();
        _validation_client=new ValidationClient();
    }

    private async Task validateContact_execute()
    {
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