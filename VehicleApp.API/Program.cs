using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VehicleApp.BLL.Abstracts;
using VehicleApp.BLL.Concretes;
using VehicleApp.DAL.Abstracts;
using VehicleApp.DAL.EntityFramework.Concretes;
using VehicleApp.DAL.EntityFramework.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConStr"));
});

//Repositories
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<IBusRepository, BusRepository>();
builder.Services.AddScoped<IBoatRepository, BoatRepository>();

//Services
builder.Services.AddScoped<ICarService, CarManager>();
builder.Services.AddScoped<IBusService, BusManager>();
builder.Services.AddScoped<IBoatService, BoatManager>();

//AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
