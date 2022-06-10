using Grpc.Core;

namespace ValidationServers.Address.Services;

public class ValidationAddressService : ValidationAddress.ValidationAddressBase
{
    private readonly ILogger<ValidationAddressService> _logger;
    public ValidationAddressService(ILogger<ValidationAddressService> logger)
    {
        _logger=logger;
    }

    public override Task<ValidationAddressReply> ValidateAddress(ValidationAddressRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ValidationAddressReply
                               { Message="Hello "+request.Name });
    }
}