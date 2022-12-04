using Hexacleanws.Vehicle.Adapter.Out.ServiceClient;
using Hexacleanws.Vehicle.Domain.Service;
using Hexacleanws.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.UseCase.Out;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<VehicleQuery, FahrzeugService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   // app.UseSwagger();
   // app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
