using Google.Protobuf;
using Grpc.Core;
using Proto;
using ValidationServers.Address;
using ValidationServers.Fullname;
using ValidationServers.Phone;
using ValidationServers.Email;
using ValidationServers.Passport;
using ValidationServers.Date;
using ResultReply=ValidationServers.Email.ResultReply;

namespace ValidationApp.Server.Services;

public class ValidationService : Validation.ValidationBase
{
    private readonly Channel _channel=new Channel("localhost", 5001, ChannelCredentials.Insecure);
    private readonly ValidationFullname.ValidationFullnameClient _client_validation_fullname;
    private readonly ValidationPhone.ValidationPhoneClient _client_validation_phone;
    private readonly ValidationEmail.ValidationEmailClient _client_validation_email;
    private readonly ValidationAddress.ValidationAddressClient _client_validation_address;
    private readonly ValidationPassport.ValidationPassportClient _client_validation_passport;
    private readonly ValidationDate.ValidationDateClient _client_validation_date;

    private List<ValidationFullnameReply> _replies_validation_fullname=new List<ValidationFullnameReply>();
    private List<ValidationPhoneReply> _replies_validation_phone=new List<ValidationPhoneReply>();
    private List<ValidationEmailReply> _replies_validation_email=new List<ValidationEmailReply>();
    private List<ValidationAddressReply> _replies_validation_address=new List<ValidationAddressReply>();
    private List<ValidationPassportReply> _replies_validation_passport=new List<ValidationPassportReply>();
    private List<ValidationDateReply> _replies_validation_date=new List<ValidationDateReply>();
    
    public ValidationService()
    {
        
    }

    private string[] splitRecord(string record, char delimiter, char removed)
    {
        string[] subs=record.Split(',');
        
        for(int i=1; i<subs.Length; i++)
            subs[i].Remove(0, 1);

        return subs;
    }
    
    private (int, bool, string[]) checkComponentCount(List<(Guid, string)> components_list, string record, int component_count_min, int component_count_max=1)
    {
        string[] components=splitRecord(record, ',', ' ');
        int component_count=components.Length;

        components_list.Add((new Guid(record), record));
        if(component_count<component_count_min || component_count>component_count_max)
            return (component_count, false, components);
        return (component_count, true, components);
    }
    
    public async override Task<ValidationReply> validate(ValidationRequest request, ServerCallContext context)
    {
        List<Task> tasks=new List<Task>();
        List<(Guid, string)> components=new List<(Guid, string)>();
        (int, bool, string[]) check_component_result;
        ValidationReply validation_reply=new ValidationReply();
        /*ResultReply result_reply=new ResultReply() 
                                {Info=""};*/
        ResultReply result_reply=new ResultReply();

        string tmp="";
        foreach (var component in request.FullName)         // TODO fullname to one string
        {
            tmp+=component;
        }
        
        check_component_result=checkComponentCount(components, tmp, 1);    // TODO все что далее можно поробовать распихать по функциям, когда время будет (проблема, как итерировать по полям реквеста?)
        if(!check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[0].Item1.ToByteArray()),
                                                     Record = components[0].Item2});
            foreach (var component in check_component_result.Item3) // TODO тут надо сделать сами парсеры (валидирующие методы на серверах) и записывать возвращаемый ими результат в общее поле Info
            {
                // TODO с запуском таски возможен быдлокод
                tasks.Add(new Task(async () => _replies_validation_fullname.Add(await _client_validation_fullname.ValidateFullnameAsync(new ValidationFullnameRequest()
                                                                                                                                        { Name=tmp }))));
            }
        }
        else
            result_reply.Result=false;
        //result_reply.Info+=$"{nameof(request.FullName)} component count is {check_component_result}";

        check_component_result=checkComponentCount(components, request.PhoneNumber, 1);
        if(!check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[0].Item1.ToByteArray()),
                                                    Record = components[1].Item2});
            foreach (var component in check_component_result.Item3)
            {
                tasks.Add(new Task(async () => _replies_validation_fullname.Add(await _client_validation_fullname.ValidateFullnameAsync(new ValidationFullnameRequest()
                                                                                                                                        { Name=tmp }))));
            }
        }
        else
            result_reply.Result=false;

        check_component_result=checkComponentCount(components, request.Email, 1);
        if(!check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[0].Item1.ToByteArray()),
                                                    Record = components[2].Item2});
            foreach (var component in check_component_result.Item3)
            {
                tasks.Add(new Task(async () => _replies_validation_fullname.Add(await _client_validation_fullname.ValidateFullnameAsync(new ValidationFullnameRequest()
                                                                                                                                        { Name=tmp }))));
            }
        }
        else
            result_reply.Result=false;

        check_component_result=checkComponentCount(components, request.Address, 1);
        if(!check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[0].Item1.ToByteArray()),
                                                    Record = components[3].Item2});
            foreach (var component in check_component_result.Item3)
            {
                tasks.Add(new Task(async () => _replies_validation_fullname.Add(await _client_validation_fullname.ValidateFullnameAsync(new ValidationFullnameRequest()
                                                                                                                                        { Name=tmp }))));
            }
        }
        else
            result_reply.Result=false;

        check_component_result=checkComponentCount(components, request.PassportNumber, 1);
        if(!check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[0].Item1.ToByteArray()),
                                                    Record = components[4].Item2});
            foreach (var component in check_component_result.Item3)
            {
                tasks.Add(new Task(async () => _replies_validation_fullname.Add(await _client_validation_fullname.ValidateFullnameAsync(new ValidationFullnameRequest()
                                                                                                                                        { Name=tmp }))));
            }
        }
        else
            result_reply.Result=false;

        check_component_result=checkComponentCount(components, request.BirthDate, 1);
        if(!check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[0].Item1.ToByteArray()),
                                                    Record = components[5].Item2});
            foreach (var component in check_component_result.Item3)
            {
                tasks.Add(new Task(async () => _replies_validation_fullname.Add(await _client_validation_fullname.ValidateFullnameAsync(new ValidationFullnameRequest()
                                                                                                                                        { Name=tmp }))));
            }
        }
        else
            result_reply.Result=false;
        
        Task.WaitAll(tasks.ToArray());
        
        foreach (var reply in _replies_validation_fullname)
        {
            result_reply.Info+=$"{nameof(request.FullName)} component count is {reply.Message}";       // TODO add results to info string
        }
        foreach (var reply in _replies_validation_email)
        {
            result_reply.Info+=$"{nameof(request.Email)} component count is {reply.Message}";
        }
        foreach (var reply in _replies_validation_address)
        {
            result_reply.Info+=$"{nameof(request.Address)} component count is {reply.Message}";
        }
        foreach (var reply in _replies_validation_passport)
        {
            result_reply.Info+=$"{nameof(request.PassportNumber)} component count is {reply.Message}";
        }
        foreach (var reply in _replies_validation_date)
        {
            result_reply.Info+=$"{nameof(request.BirthDate)} component count is {reply.Message}";
        }
        foreach (var reply in _replies_validation_phone)
        {
            result_reply.Info+=$"{nameof(request.PhoneNumber)} component count is {reply.Message}";
        }

        return validation_reply;
    }
}