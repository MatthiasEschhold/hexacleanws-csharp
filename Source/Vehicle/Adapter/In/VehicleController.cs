using Hexacleanws.Source.Vehicle.Adapter.In.Web;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Adapter.In.Web;

namespace Hexacleanws.Source.Vehicle.Adapter.In
{
    public class VehicleController
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

        public VehicleResource ReadVehicle(string vin)
        {
            VehicleRootEntity entity = VehicleQuery.FindByVin(new Vin(vin));
            return Mapper.MapVehicleToVehicleResource(entity);
        }

        public VehicleResource UpdateVehicle(String vin, VehicleMotionDataResource vehicleMotionData)
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
