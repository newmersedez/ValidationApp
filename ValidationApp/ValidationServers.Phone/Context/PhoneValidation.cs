using System.Text.RegularExpressions;

namespace ValidationServers.PhoneNumber.Context;

public interface IValidator
{
    bool Validate(string param);
}
public sealed class PropertyValidator
{
    private readonly IValidator _validator;
        
    public PropertyValidator(IValidator validator)
    {
        _validator = validator;
    }

    public bool Validate(string param)
    {
        return _validator.Validate(param);
    }
}
public sealed class PhoneValidator : IValidator
{
    public bool Validate(string param)
    {
        param = param.TrimEnd(new char[] { '\r', '\n' });
        var phoneNumbers = param.Split('\n');
        return phoneNumbers.All(phone => Regex.Match(phone, @"^(\+[0-9]{11})$").Success);
    }
}