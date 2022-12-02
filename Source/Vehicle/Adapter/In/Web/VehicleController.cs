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
        private readonly VehicleQuery fetchVehicle;
        private readonly ILogger<VehicleController> logger;

        private static readonly MapperConfiguration Config = new(cfg => cfg.CreateMap<VehicleRootEntity, VehicleResource>());
        private Mapper mapper;

        public VehicleController(VehicleQuery fetchVehicle, ILogger<VehicleController> logger)
        {
            this.fetchVehicle = fetchVehicle;
            this.mapper = new Mapper(Config);
            this.logger = logger;
        }

        [HttpGet(Name = "GetVehicle")]
        public VehicleResource GetVehicle(string id)
        {
            var fahrzeug = fetchVehicle.Fetch(id);
            return mapper.Map<VehicleResource>(fahrzeug);
        }

    }
}
