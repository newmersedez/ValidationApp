using System.Collections.Generic;

namespace ValidationApp.MVVM.Model;

public sealed class Contact
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Patronymic { get; set; }
    public string PassportNumber { get; set; }
    public string BirthdayDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}