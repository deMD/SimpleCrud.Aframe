using Microsoft.AspNetCore.Mvc;
using SimpleCrud.Api;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("crud", new CreateHandler().Handle);

app.Run();