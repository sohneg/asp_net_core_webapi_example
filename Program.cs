using webApi.Interfaces;
using webApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Dependency Injection für ITestModelRepository
builder.Services.AddScoped<ITestModelRepository, TestModelRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Fügt die Routing-Middleware hinzu
app.UseRouting();

app.MapControllers();

app.Run();
