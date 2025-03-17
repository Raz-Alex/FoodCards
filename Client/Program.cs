using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FoodCards.Client;
using FoodCards.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("FoodCards.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("FoodCards.ServerAPI"));
builder.Services.AddScoped<DishSetUpDataService>();
builder.Services.AddScoped<AuthorizeMonitorService>();
builder.Services.AddScoped<LocalStorage>();
builder.Services.AddScoped<AuthorizeHttpClient>();

await builder.Build().RunAsync();
