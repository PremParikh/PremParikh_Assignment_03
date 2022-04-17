using Microsoft.AspNetCore.Components.Web;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

internal class WebAssemblyHostBuilder
{
    internal static object CreateDefault(string[] args)
    {
        throw new NotImplementedException();
    }
}

var configurationBuilder = builder.RootComponents.Add<App>("""#app""");
IConfigurationBuilder configurationBuilder1 = builder.RootComponents.Add<HeadOutlet>("head::after");

IServiceCollection serviceCollection = builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build()
             .RunAsync();
