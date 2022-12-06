using Hexacleanws.Vehicle.Adapter.Out.ServiceClient;
using Hexacleanws.Vehicle.Domain.Service;
using Hexacleanws.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.UseCase.Out;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();


app.MapControllers();

app.Run();
