using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebHookApp.Client.Services;


namespace WebHookApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Reference App component as root component
            builder.RootComponents.Add<App>("#app");


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7053/") });
            builder.Services.AddScoped<WebHookService>();

            await builder.Build().RunAsync();
        }
    }
}
