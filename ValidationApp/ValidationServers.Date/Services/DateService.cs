using Grpc.Core;
using ValidationServers.Date;

namespace ValidationServers.Date.Services;

public class ValidationDateService : ValidationDate.ValidationDateBase
{
    private readonly ILogger<ValidationDateService> _logger;
    public ValidationDateService(ILogger<ValidationDateService> logger)
    {
        _logger=logger;
    }

    public override Task<ValidationDateReply> ValidateDate(ValidationDateRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ValidationDateReply
                               { Message="Hello "+request.Name });
    }
}