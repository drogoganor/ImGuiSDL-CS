using ImGuiSDL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


//using var app = new Application("ImGui C# SDL GPU Sample", 1280, 720, debugMode: true);
//app.Run();


var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((hostContext, services) =>
{
    services
        .AddEngine();
});

var host = builder.Build();

Application application;
try
{
    application = host.Services.GetRequiredService<Application>();
}
catch (Exception ex)
{
    var log = host.Services.GetRequiredService<ILogger>();
    //log.Error("Error creating Application: {message}", ex.Message);
    return;
}

application.Run();
