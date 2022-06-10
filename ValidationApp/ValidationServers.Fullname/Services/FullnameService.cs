using Grpc.Core;
using ValidationServers.Fullname;

namespace ValidationServers.Fullname.Services;

public class ValidationFullnameService : ValidationFullname.ValidationFullnameBase
{
    private readonly ILogger<ValidationFullnameService> _logger;
    public ValidationFullnameService(ILogger<ValidationFullnameService> logger)
    {
        _logger=logger;
    }

    public override Task<ValidationFullnameReply> ValidateFullname(ValidationFullnameRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ValidationFullnameReply
                               { Message="Hello "+request.Name });
    }
}