using BlazorEngenharia;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");

        builder.Services.AddAuthorizationCore();
        builder.Services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();

        // Configurar HttpClient com suporte a autenticação
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        // Configurar o serviço de autorização
        builder.Services.AddAuthorizationCore();

        await builder.Build().RunAsync();
    }
}
