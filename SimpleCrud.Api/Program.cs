using MinimalApi.Endpoint.Extensions;
using SimpleCrud.Api.Create;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpoints();
builder.Services.AddScoped<CreateRepository>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapEndpoints();

app.Run();