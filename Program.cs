using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Adds support for controllers

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection(); // Redirects HTTP to HTTPS for security

app.UseRouting();

app.UseAuthorization(); // Enables Authorization Middleware if needed

app.MapControllers(); // Maps controller endpoints

app.Run();
