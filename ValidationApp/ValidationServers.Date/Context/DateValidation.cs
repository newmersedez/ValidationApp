using System.Text.RegularExpressions;

namespace ValidationServers.Date.Context;

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
public sealed class DateValidator : IValidator
{
    public bool Validate(string param)
    {
        param = param.TrimEnd(new char[] { '\r', '\n' });
        return Regex.Match(param,
                           @"^([0-2][0-9]|(3)[0-1])(\.)(((0)[0-9])|((1)[0-2]))(\.)\d{4}$").Success;
    }
}