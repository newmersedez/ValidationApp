using Google.Protobuf;
using Grpc.Core;
using Proto;
using ValidationServers.Address;
using ValidationServers.Fullname;
using ValidationServers.Phone;
using ValidationServers.Email;
using ValidationServers.Passport;
using ValidationServers.Date;
using System.Security.Cryptography;
using System.Text;

namespace ValidationApp.Server.Services;

public class ValidationService : Validation.ValidationBase
{
    private readonly Channel _channel_address=new Channel("localhost", 5002, ChannelCredentials.Insecure);
    private readonly Channel _channel_date=new Channel("localhost", 5003, ChannelCredentials.Insecure);
    private readonly Channel _channel_email=new Channel("localhost", 5004, ChannelCredentials.Insecure);
    private readonly Channel _channel_fullname=new Channel("localhost", 5005, ChannelCredentials.Insecure);
    private readonly Channel _channel_passport=new Channel("localhost", 5006, ChannelCredentials.Insecure);
    private readonly Channel _channel_phone=new Channel("localhost", 5007, ChannelCredentials.Insecure);
    private readonly ValidationFullname.ValidationFullnameClient _client_validation_fullname;
    private readonly ValidationPhone.ValidationPhoneClient _client_validation_phone;
    private readonly ValidationEmail.ValidationEmailClient _client_validation_email;
    private readonly ValidationAddress.ValidationAddressClient _client_validation_address;
    private readonly ValidationPassport.ValidationPassportClient _client_validation_passport;
    private readonly ValidationDate.ValidationDateClient _client_validation_date;

    private ValidationServers.Fullname.DataReply _data_reply_fullname=null;
    private ValidationServers.Fullname.DataRequest _data_request_fullname=new ValidationServers.Fullname.DataRequest() {Connected = true};
    private ValidationServers.Phone.DataReply _data_reply_phone=null;
    private ValidationServers.Phone.DataRequest _data_request_phone=new ValidationServers.Phone.DataRequest() {Connected = true};
    private ValidationServers.Email.DataReply _data_reply_email=null;
    private ValidationServers.Email.DataRequest _data_request_email=new ValidationServers.Email.DataRequest() {Connected = true};
    private ValidationServers.Address.DataReply _data_reply_address=null;
    private ValidationServers.Address.DataRequest _data_request_address=new ValidationServers.Address.DataRequest() {Connected = true};
    private ValidationServers.Passport.DataReply _data_reply_passport=null;
    private ValidationServers.Passport.DataRequest _data_request_passport=new ValidationServers.Passport.DataRequest() {Connected = true};
    private ValidationServers.Date.DataReply _data_reply_date=null;
    private ValidationServers.Date.DataRequest _data_request_date=new ValidationServers.Date.DataRequest() {Connected = true};

    public ValidationService()
    {
        _client_validation_address=new ValidationAddress.ValidationAddressClient(_channel_address);
        _client_validation_date=new ValidationDate.ValidationDateClient(_channel_date);
        _client_validation_email=new ValidationEmail.ValidationEmailClient(_channel_email);
        _client_validation_fullname=new ValidationFullname.ValidationFullnameClient(_channel_fullname);
        _client_validation_passport=new ValidationPassport.ValidationPassportClient(_channel_passport);
        _client_validation_phone=new ValidationPhone.ValidationPhoneClient(_channel_phone);
    }
    
    #region meh
    private async Task getDataFromFullnameServer(int delay=500)
    {
        while(true)
        {
            await Task.Delay(delay);
            _data_reply_fullname=await _client_validation_fullname.GetServerDataAsync(_data_request_fullname);
             if(_data_reply_fullname.Result.Result==false && _data_reply_fullname.Result.Info=="N/A")
                 continue;
             else
             {
                 _data_request_fullname.Connected=false;
                 await _client_validation_fullname.GetServerDataAsync(_data_request_fullname);
                 break;
             }
        }
    }
    private async Task getDataFromPassportServer(int delay=500)
    {
        while(true)
        {
            await Task.Delay(delay);
            _data_reply_passport=await _client_validation_passport.GetServerDataAsync(_data_request_passport);
            if(_data_reply_passport.Result.Result==false && _data_reply_passport.Result.Info=="N/A")
                continue;
            else
            {
                _data_request_passport.Connected=false;
                await _client_validation_passport.GetServerDataAsync(_data_request_passport);
                break;
            }
        }
    }
    private async Task getDataFromEmailServer(int delay=500)
    {
        while(true)
        {
            await Task.Delay(delay);
            _data_reply_email=await _client_validation_email.GetServerDataAsync(_data_request_email);
            if(_data_reply_email.Result.Result==false && _data_reply_email.Result.Info=="N/A")
                continue;
            else
            {
                _data_request_email.Connected=false;
                await _client_validation_email.GetServerDataAsync(_data_request_email);
                break;
            }
        }
    }
    private async Task getDataFromAddressServer(int delay=500)
    {
        while(true)
        {
            await Task.Delay(delay);
            _data_reply_address=await _client_validation_address.GetServerDataAsync(_data_request_address);
            if(_data_reply_address.Result.Result==false && _data_reply_address.Result.Info=="N/A")
                continue;
            else
            {
                _data_request_address.Connected=false;
                await _client_validation_address.GetServerDataAsync(_data_request_address);
                break;
            }
        }
    }
    private async Task getDataFromPhoneServer(int delay=500)
    {
        while(true)
        {
            await Task.Delay(delay);
            _data_reply_phone=await _client_validation_phone.GetServerDataAsync(_data_request_phone);
            if(_data_reply_phone.Result.Result==false && _data_reply_phone.Result.Info=="N/A")
                continue;
            else
            {
                _data_request_phone.Connected=false;
                await _client_validation_phone.GetServerDataAsync(_data_request_phone);
                break;
            }
        }
    }
    private async Task getDataFromDateServer(int delay=500)
    {
        while(true)
        {
            await Task.Delay(delay);
            _data_reply_date=await _client_validation_date.GetServerDataAsync(_data_request_date);
            if(_data_reply_date.Result.Result==false && _data_reply_date.Result.Info=="N/A")
                continue;
            else
            {
                _data_request_date.Connected=false;
                await _client_validation_date.GetServerDataAsync(_data_request_date);
                break;
            }
        }
    }
    #endregion
    
    private string[] splitRecord(string record, char separator, bool remove=true)
    {
        string[] subs=record.Split(separator);
        
        if(remove)
            for(int i=1; i<subs.Length; i++)
                subs[i].Remove(0, 1);

        return subs;
    }
    
    private (int, bool, string[]) checkComponentCount(List<(Guid, string)> components_list, string record, int component_count_min, int component_count_max=1, bool remove=true)
    {
        string[] components=splitRecord(record, ',', remove);
        int component_count=components.Length;

        MD5 md5=MD5.Create();
        components_list.Add((new Guid(md5.ComputeHash(Encoding.UTF8.GetBytes(record))), record));
        if(component_count<component_count_min || component_count>component_count_max)
            return (component_count, false, components);
        return (component_count, true, components);
    }

    /*private async void meth(List<Task> tasks, (int, bool, string[]) check_component_result, Proto.ResultReply result_reply, List<(Guid, string)> components, ValidationReply validation_reply, ValidationRequest request, Func<Task> tsk, Action dat)
    {
        if(!check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[0].Item1.ToByteArray()),
                                                    Record = components[1].Item2});
            foreach (var component in check_component_result.Item3)
                tasks.Add(Task.Run(tsk));
            await Task.Run(() => dat);
        }
        else
            result_reply.Result=false;
    }*/

    public async override Task<ValidationReply> validate(ValidationRequest request, ServerCallContext context)
    {
        List<Task> tasks=new List<Task>();
        List<(Guid, string)> components=new List<(Guid, string)>();
        (int, bool, string[]) check_component_result;
        ValidationReply validation_reply=new ValidationReply();
        Proto.ResultReply result_reply=new Proto.ResultReply();

        var authentication_reply_fullname = await _client_validation_fullname.AuthenticateAsync(new  ValidationServers.Fullname.AuthenticationRequest());
        if(!authentication_reply_fullname.Result.Result)
        {
            // TODO unable to connect
        }
        _data_request_fullname.Id=authentication_reply_fullname.Id;

        check_component_result=checkComponentCount(components, request.FullName, 1, 1, false);
        if(check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[0].Item1.ToByteArray()),
                                                     Record = components[0].Item2});
            foreach (var component in check_component_result.Item3)
                tasks.Add(Task.Run(async () => await _client_validation_fullname.ValidateFullnameAsync(new ValidationFullnameRequest()
                                                                                                                                        {Id=_data_request_fullname.Id, Data=component})));
            _data_request_fullname.Count=(uint)check_component_result.Item3.Length;
            await Task.Run(() => getDataFromFullnameServer());
        }
        else
            result_reply.Result=false;

        var authentication_reply_phone = await _client_validation_phone.AuthenticateAsync(new  ValidationServers.Phone.AuthenticationRequest());
        if(!authentication_reply_phone.Result.Result)
        {
            // TODO unable to connect
        }
        _data_request_phone.Id=authentication_reply_phone.Id;
        
        check_component_result=checkComponentCount(components, request.PhoneNumber, 1, 3);
        if(check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[1].Item1.ToByteArray()),
                                                    Record = components[1].Item2});
            foreach (var component in check_component_result.Item3)
                tasks.Add(Task.Run(async () => await _client_validation_phone.ValidatePhoneAsync(new ValidationPhoneRequest()
                                                                                                                                        {Id=_data_request_phone.Id, Data=component})));
            _data_request_phone.Count=(uint)check_component_result.Item3.Length;
            await Task.Run(() => getDataFromPhoneServer());
        }
        else
            result_reply.Result=false;

        var authentication_reply_email = await _client_validation_email.AuthenticateAsync(new ValidationServers.Email.AuthenticationRequest());
        if(!authentication_reply_email.Result.Result)
        {
            // TODO unable to connect
        }
        _data_request_email.Id=authentication_reply_email.Id;
        
        check_component_result=checkComponentCount(components, request.Email, 1, 3);
        if(check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[2].Item1.ToByteArray()),
                                                    Record = components[2].Item2});
            foreach (var component in check_component_result.Item3)
                tasks.Add(Task.Run(async () => await _client_validation_email.ValidateEmailAsync(new ValidationEmailRequest()
                                                                                                       {Id=_data_request_email.Id, Data=component})));
            _data_request_email.Count=(uint)check_component_result.Item3.Length;
            await Task.Run(() => getDataFromEmailServer());
        }
        else
            result_reply.Result=false;

        var authentication_reply_address = await _client_validation_address.AuthenticateAsync(new ValidationServers.Address.AuthenticationRequest());
        if(!authentication_reply_address.Result.Result)
        {
            // TODO unable to connect
        }
        _data_request_address.Id=authentication_reply_address.Id;
        
        check_component_result=checkComponentCount(components, request.Address, 1, 2);
        if(check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[3].Item1.ToByteArray()),
                                                    Record = components[3].Item2});
            foreach (var component in check_component_result.Item3)
                tasks.Add(Task.Run(async () => await _client_validation_address.ValidateAddressAsync(new ValidationAddressRequest()
                                                                                                       {Id=_data_request_address.Id, Data=component})));
            _data_request_address.Count=(uint)check_component_result.Item3.Length;
            await Task.Run(() => getDataFromAddressServer());
        }
        else
            result_reply.Result=false;

        var authentication_reply_passport = await _client_validation_passport.AuthenticateAsync(new ValidationServers.Passport.AuthenticationRequest());
        if(!authentication_reply_passport.Result.Result)
        {
            // TODO unable to connect
        }
        _data_request_passport.Id=authentication_reply_passport.Id;
        
        check_component_result=checkComponentCount(components, request.PassportNumber, 1);
        if(check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[4].Item1.ToByteArray()),
                                                    Record = components[4].Item2});
            foreach (var component in check_component_result.Item3)
                tasks.Add(Task.Run(async () => await _client_validation_passport.ValidatePassportAsync(new ValidationPassportRequest()
                                                                                                       {Id=_data_request_passport.Id, Data=component})));
            _data_request_passport.Count=(uint)check_component_result.Item3.Length;
            await Task.Run(() => getDataFromPassportServer());
        }
        else
            result_reply.Result=false;

        var authentication_reply_date = await _client_validation_date.AuthenticateAsync(new  ValidationServers.Date.AuthenticationRequest());
        if(!authentication_reply_date.Result.Result)
        {
            // TODO unable to connect
        }
        _data_request_date.Id=authentication_reply_date.Id;
        
        check_component_result=checkComponentCount(components, request.BirthDate, 1);
        if(check_component_result.Item2)
        {
            validation_reply.ValidationResult.Add(new ValidationResult()
                                                  { Guid=ByteString.CopyFrom(components[5].Item1.ToByteArray()),
                                                    Record = components[5].Item2});
            foreach (var component in check_component_result.Item3)
                tasks.Add(Task.Run(async () => await _client_validation_date.ValidateDateAsync(new ValidationDateRequest()
                                                                                                       {Id=_data_request_date.Id, Data=component})));
            _data_request_date.Count=(uint)check_component_result.Item3.Length;
            await Task.Run(() => getDataFromDateServer());
        }
        else
            result_reply.Result=false;
        
        Task.WaitAll(tasks.ToArray());

        for(int i=0; _data_reply_address==null || _data_reply_date==null || _data_reply_email==null || _data_reply_passport==null || _data_reply_phone==null || _data_reply_fullname==null; i++)
        {
            if(i>20)
            {
                result_reply.Result=false;
                result_reply.Info="Validation time exceeded";
                return validation_reply;
            }
            await Task.Delay(1000);
        }

        result_reply.Result=_data_reply_address.Result.Result & _data_reply_date.Result.Result & _data_reply_email.Result.Result & _data_reply_passport.Result.Result & _data_reply_phone.Result.Result & _data_reply_fullname.Result.Result;
        result_reply.Info=_data_reply_address.Result.Info + _data_reply_date.Result.Info + _data_reply_email.Result.Info + _data_reply_passport.Result.Info + _data_reply_phone.Result.Info + _data_reply_fullname.Result.Info;

        return validation_reply;
    }
}