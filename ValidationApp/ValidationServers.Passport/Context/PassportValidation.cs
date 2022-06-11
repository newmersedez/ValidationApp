using System.Text.RegularExpressions;

namespace ValidationServers.Passport.Context;

public interface IValidator
{
    bool Validate(string param);
}

public sealed class PassportValidator : IValidator
{
    public bool Validate(string param)
    {
        param = param.TrimEnd(new char[] { '\r', '\n' });
        return Regex.Match(param, @"\d{4}\s\d{6}").Success;
    }
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
