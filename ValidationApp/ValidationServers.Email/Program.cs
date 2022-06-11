using ValidationServers.Email.Services;

var builder=WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();
builder.Services.AddSingleton(new ValidationEmailService());

var app=builder.Build();
app.MapGrpcService<ValidationEmailService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();