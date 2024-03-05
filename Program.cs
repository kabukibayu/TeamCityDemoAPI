using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DotnetApiTemplate.WebApi.Endpoints.Sample;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();


app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers(); 
});

app.Run("http://jarex.alwaysdata.net:5000/");
