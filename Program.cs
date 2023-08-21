using BuberBreakfast.Database;
using BuberBreakfast.Services.breakfast;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().Providers.FirstOrDefault();
string connectionStrings;
configuration.TryGet("ConnectionStrings",out connectionStrings);
builder.Services.AddControllers();
builder.Services.AddScoped<IBreakfastService, BreakfastService>(_=> new BreakfastService(connectionStrings));
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

app.MapControllers();

app.Run();
