using System.Text.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Fictionary.Client;
using Flurl.Http;
using Flurl.Http.Configuration;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
builder.Services.AddMudServices();

FlurlHttp.Configure(settings => settings.JsonSerializer = settings.JsonSerializer =
    new DefaultJsonSerializer(new JsonSerializerOptions(JsonSerializerDefaults.Web)));

await builder.Build().RunAsync();