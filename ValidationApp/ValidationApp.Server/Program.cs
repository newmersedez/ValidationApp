using ValidationApp.Server.Services;

WebApplicationBuilder builder=WebApplication.CreateBuilder(args);
WebApplication app;

builder.Services.AddGrpc();
//builder.Services.AddSingleton(new ValidationService());

app=builder.Build();
app.MapGrpcService<ValidationService>();;
app.MapGet("/", () => "blah");
app.Run();