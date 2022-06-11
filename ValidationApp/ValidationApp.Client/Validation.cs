using Grpc.Core;
using Grpc.Net.Client;
using Proto;
using ValidationApp.Context;

namespace ValidationApp.Client;

public sealed class ValidationClient
{
    private readonly Channel _channel=new Channel("localhost", 5001, ChannelCredentials.Insecure);
    private readonly Validation.ValidationClient _client_validation;
    private ValidationRequest _validation_request=new ValidationRequest();

    public ValidationClient()
    {
        _client_validation=new Validation.ValidationClient(_channel);
    }

    public async Task<ValidationReply> validate(Contact contact)
    {
        _validation_request.FullName=contact.Firstname+" "+contact.Lastname+" "+contact.Patronymic;
        _validation_request.PhoneNumber=contact.PhoneNumber;
        _validation_request.Email=contact.Email;
        _validation_request.Address=contact.Address;
        _validation_request.PassportNumber=contact.PassportNumber;
        _validation_request.BirthDate=contact.BirthdayDate;
        return await _client_validation.validateAsync(_validation_request);
    }
}