using Grpc.Core;
using ValidationServers.Phone;

namespace ValidationServers.Phone.Services;

public class ValidationPhoneService : ValidationPhone.ValidationPhoneBase
{
    private readonly ILogger<ValidationPhoneService> _logger;
    public ValidationPhoneService(ILogger<ValidationPhoneService> logger)
    {
        _logger=logger;
    }

    public override Task<ValidationPhoneReply> ValidatePhone(ValidationPhoneRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ValidationPhoneReply
                               { Message="Hello "+request.Name });
    }
}