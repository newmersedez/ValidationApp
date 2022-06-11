namespace ValidationServers.Fullname.Context;

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

public sealed class FullnameValidator : IValidator
{
    public bool Validate(string param)
    {
        param = param.TrimEnd(new char[] { '\r', '\n' });
        var fullname = param.Split(' ');
        if (fullname.Length != 3)
            return false;
        foreach (var part in fullname)
        {
            if (!part.All(char.IsLetter))
                return false;
        }
        return true;
    }
}