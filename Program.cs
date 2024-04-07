#region 1. Minimal Web API
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
#endregion


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapGet("/", () => "Hello, World from Web API!");

app.Run();
