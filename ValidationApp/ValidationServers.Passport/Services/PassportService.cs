using Grpc.Core;
using ValidationServers.Passport;

namespace ValidationServers.Passport.Services;

public class ValidationPassportService : ValidationPassport.ValidationPassportBase
{
    private readonly ILogger<ValidationPassportService> _logger;
    public ValidationPassportService(ILogger<ValidationPassportService> logger)
    {
        _logger=logger;
    }

    public override Task<ValidationPassportReply> ValidatePassport(ValidationPassportRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ValidationPassportReply
                               { Message="Hello "+request.Name });
    }
}