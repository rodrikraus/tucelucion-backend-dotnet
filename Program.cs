using Microsoft.EntityFrameworkCore;
using MiPrimeraApi.Context;
using DotNetEnv;



var builder = WebApplication.CreateBuilder(args);

// Load .env file into environment variables
Env.Load();

// Add services to the container.
var connectionString = Environment.GetEnvironmentVariable("SupabaseTuCelucion");
//Registrar servicio para la conexion
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

