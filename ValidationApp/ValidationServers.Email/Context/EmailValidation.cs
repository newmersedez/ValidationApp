using System.Text.RegularExpressions;

namespace ValidationServers.Email.Context;

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
public sealed class EmailValidator : IValidator
{
    public bool Validate(string param)
    {
        param = param.TrimEnd(new char[] { '\r', '\n' });
        var emails = param.Split('\n');
        return emails.All(email => Regex.Match(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success);
    }
}