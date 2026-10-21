using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWasmBrasilApiCep;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registra o HttpClient apontando para a BrasilAPI (https://brasilapi.com.br/api/cep/v1/{cep})
// Atenção: a barra final em "/api/" é necessária para o BaseAddress combinar com a rota relativa.
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://brasilapi.com.br/api/")
});

await builder.Build().RunAsync();
