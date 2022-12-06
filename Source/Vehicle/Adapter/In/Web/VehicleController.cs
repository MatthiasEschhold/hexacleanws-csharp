using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.In;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Vehicle.Adapter.In.Web
{
    //[ApiController]
    //[Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleQuery VehicleQuery;
        private readonly VehicleCommand VehicleCommand;
        private readonly VehicleToVehicleResourceMapper Mapper;

        public VehicleController(VehicleQuery vehicleQuery, VehicleCommand vehicleCommand, VehicleToVehicleResourceMapper mapper)
        {
            VehicleQuery = vehicleQuery;
            VehicleCommand = vehicleCommand;
            Mapper = mapper;
        }

        //[HttpGet(Name = "GetVehicle")]
        public VehicleResource GetVehicle(string id)
        {
            var vehicle = VehicleQuery.FindByVin(new Vin(id));
            return Mapper.MapVehicleToVehicleResource(vehicle);
        }

        public VehicleResource UpdateVehicle(string vin, VehicleMotionDataResource vehicleMotionData)
        {
            VehicleRootEntity vehicle = VehicleCommand.Update(new Vin(vin), Mapper.MapVehicleMotionDataResourceToVehicleMotionData(vehicleMotionData));
            return Mapper.MapVehicleToVehicleResource(vehicle);
        }

        public VehicleResource CreateVehicle(VehicleResource resource)
        {
            VehicleRootEntity vehicle = VehicleCommand.Create(Mapper.MapVehicleResourceToVehicle(resource));
            return Mapper.MapVehicleToVehicleResource(vehicle);
        }

    }
}
