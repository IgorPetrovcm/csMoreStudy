using Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSqlite<ApplicationContext>("Data Source=local.db");

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
