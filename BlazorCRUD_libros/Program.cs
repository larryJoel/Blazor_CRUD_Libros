using BlazorCRUD_libros;
using BlazorCRUD_libros.Data;
using BlazorCRUD_libros.Repositorio;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//configuraci�n de la cadena de conexion
builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(
    builder.Configuration.GetConnectionString("CadenaSQL")));

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();

//Se agrega como inyecci�n de dependencias el repositorio
builder.Services.AddScoped<IRepositorio, Repositorio>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
