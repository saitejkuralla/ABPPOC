using IMM.Signature;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseAutofac();

builder.Services.ReplaceConfiguration(builder.Configuration);

builder.Services.AddApplication<IMMModule>();

var app = builder.Build();

app.InitializeApplication();

app.Run();






