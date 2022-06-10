using Grpc.Core;
using ValidationServers.Email;

namespace ValidationServers.Email.Services;

public class ValidationEmailService : ValidationEmail.ValidationEmailBase
{
    private readonly ILogger<ValidationEmailService> _logger;
    public ValidationEmailService(ILogger<ValidationEmailService> logger)
    {
        _logger=logger;
    }

    public override Task<ValidationEmailReply> ValidateEmail(ValidationEmailRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ValidationEmailReply
                               { Message="Hello "+request.Name });
    }
}