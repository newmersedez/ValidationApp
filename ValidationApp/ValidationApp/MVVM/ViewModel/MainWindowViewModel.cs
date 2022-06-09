using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using MVVM.Core.Command;
using MVVM.Core.ViewModel;
using ValidationApp.MVVM.Model;

namespace ValidationApp.MVVM.ViewModel;

public sealed class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Contact> Contacts { get; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public string Patronymic { get; set; }
    public string PassportNumber { get; set; }
    public string BirthdayDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public RelayCommand CreateNewContactCommand { get; }

    public MainWindowViewModel()
    {
        Lastname = "Тришин";
        Firstname = "Дмитрий";
        Patronymic = "Александрович";
        PassportNumber = "2220 232743";
        BirthdayDate = "19.01.2001";
        PhoneNumber = "+79290481474";
        Email = "trishkk2001@gmail.com";
        Address = "Lalka";

        Contacts = new ObservableCollection<Contact>();
        CreateNewContactCommand = new RelayCommand(
            _ => CreateNewContact(), _ => ValidateContactInfo());
    }

    private bool ValidateContactInfo()
    {
        // Тут по идее отправление данных на сервер для валидации и возврат true/false
        // а пока большой if =)
        if (!string.IsNullOrEmpty(Lastname) && !string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Patronymic)
            && !string.IsNullOrEmpty(PhoneNumber) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Address)
            && !string.IsNullOrEmpty(PassportNumber) && !string.IsNullOrEmpty(BirthdayDate))
            return true;
        return false;
    }

    private void CreateNewContact()
    {
        // создание карточки нового контакта
        var newContact = new Contact
        {
            Lastname = Lastname,
            Firstname = Firstname,
            Patronymic = Patronymic,
            PassportNumber = PassportNumber,
            BirthdayDate = BirthdayDate,
            PhoneNumber = PhoneNumber,
            Email = Email,
            Address = Address
        };
        
        Application.Current.Dispatcher?.Invoke(()=> Contacts.Add(newContact));
    }
}