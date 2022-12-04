using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using Hexacleanws.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Adapter.In.Web
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleQuery vehicleQuery;
        private readonly ILogger<VehicleController> logger;

        private static readonly MapperConfiguration Config = new(cfg => cfg.CreateMap<VehicleRootEntity, VehicleResource>());
        private Mapper mapper;

        public VehicleController(VehicleQuery fetchVehicle, ILogger<VehicleController> logger)
        {
            this.vehicleQuery = fetchVehicle;
            this.logger = logger;
            this.mapper = new Mapper(Config);
        }

        [HttpGet(Name = "GetVehicle")]
        public VehicleResource GetVehicle(string id)
        {
            var fahrzeug = vehicleQuery.FindByVin(new Vin(id));
            return mapper.Map<VehicleResource>(fahrzeug);
        }

    }
}
