using System.Text;
using Grpc.Core;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ValidationServers.Email;
using ValidationServers.Email.Context;

namespace ValidationServers.Email.Services;

public class ValidationEmailService : ValidationEmail.ValidationEmailBase
{
    private ulong _id_counter=0;
    private readonly ILogger<ValidationEmailService> _logger;
    private ConnectionFactory _rabbit_factory;
    private IConnection _rabbit_connection;
    private IModel _rabbit_model;
    private Container.Container container=new Container.Container();
    private EventingBasicConsumer _consumer;
    private Dictionary<ulong, List<ResultReply>> _validated_data=new Dictionary<ulong, List<ResultReply>>();
    public ValidationEmailService()
    {
        container.Register<IValidator, EmailValidator>();
        _rabbit_factory=new ConnectionFactory() { HostName = "localhost" };
        _rabbit_connection=_rabbit_factory.CreateConnection();
        _rabbit_model=_rabbit_connection.CreateModel();
        _consumer= new EventingBasicConsumer(_rabbit_model);
        _consumer.Received+=(model, ea) =>
        {
            byte[] body = ea.Body.ToArray();
            byte[] bytes_id=new byte[8];
            byte[] bytes_data=new byte[body.Length-8];
            
            Array.Copy(body, 0, bytes_id,   0, 8);
            Array.Copy(body, 8, bytes_data, 0, bytes_data.Length);

            ulong id=BitConverter.ToUInt64(bytes_id);
            string data = Encoding.UTF8.GetString(bytes_data);
            var validator=container.Create<IValidator>();
            if(validator.Validate(data))
            {
                _validated_data[id].Add(new ResultReply()
                                        { Result=true,
                                          Info="Email true;" });
            }
            else
            {
                _validated_data[id].Add(new ResultReply()
                                        { Result=false,
                                          Info="Email false;" });
            }
        };
    }

    public override Task<AuthenticationReply> Authenticate(AuthenticationRequest request, ServerCallContext context)
    {
        _validated_data.Add(_id_counter, new List<ResultReply>());
        
        return Task.FromResult(new AuthenticationReply()
                               { Result = new ResultReply()
                                 { Result = true,
                                 Info = "Connected."
                                  },
                               Id=_id_counter++ });
    }
    public override Task<DataReply> GetServerData(DataRequest request, ServerCallContext context)
    {
        if(request.Connected==false)
        {
            _validated_data.Remove(request.Id);
            return Task.FromResult(new DataReply() {Result = new ResultReply() {Result = false, Info = "N/A"}});;
        }
        if(_validated_data[request.Id].Count==request.Count)
        {
            ResultReply result_reply=new ResultReply() {Result = true};
            foreach (var result in _validated_data[request.Id])
            {
                if(!result.Result)
                    result_reply.Result=false;
                result_reply.Info+=result.Info;
            }
            return Task.FromResult(new DataReply() {Result = result_reply});
        }
        return Task.FromResult(new DataReply() {Result = new ResultReply() {Result = false, Info = "N/A"}});;
    }
    public override Task<ValidationEmailReply> ValidateEmail(ValidationEmailRequest request, ServerCallContext context)
    {
        _rabbit_model.QueueDeclare(queue: "email", durable: false, exclusive: false, autoDelete: false, arguments: null);

        byte[] id=BitConverter.GetBytes(request.Id);
        byte[] data = Encoding.UTF8.GetBytes(request.Data);
        byte[] body=new byte[id.Length+data.Length];
        id.CopyTo(body, 0);
        data.CopyTo(body, 8);
        
        _rabbit_model.BasicPublish(exchange: "", routingKey: "email", basicProperties: null, body: body);
        _rabbit_model.BasicConsume(queue: "email", autoAck: true, consumer: _consumer);


        return Task.FromResult(new ValidationEmailReply()
                               { Result = new ResultReply()
                                 { Result=true,
                                   Info = "dsa"}});
    }
}