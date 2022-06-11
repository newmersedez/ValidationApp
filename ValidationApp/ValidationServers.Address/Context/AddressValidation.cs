namespace ValidationServers.Address.Context;

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
public sealed class AddressValidator : IValidator
{
    public bool Validate(string param)
    {
        param = param.TrimEnd(new char[] { '\r', '\n' });
        var addresses = param.Split('\n');
        foreach (var address in addresses)
        {
            if (string.IsNullOrEmpty(address))
                return false;
        }
        return true;
    }
}