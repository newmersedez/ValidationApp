//using ValidationApp.Services;

using ValidationApp.Server.Services;

WebApplicationBuilder builder=WebApplication.CreateBuilder(args);
WebApplication app;

builder.Services.AddGrpc();
builder.Services.AddSingleton(new ValidationService());
//builder.Services.AddSingleton(new FileStorageService());

app=builder.Build();
//app.MapGrpcService<AuthenticationService>(); app.MapGrpcService<FileStorageService>();
app.MapGet("/", () => "blah");
app.Run();