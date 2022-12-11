using Hexacleanws.Source.Vehicle.Adapter.In.Web;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;

namespace Hexacleanws.Source.Vehicle.Adapter.In
{
    public class VehicleController
    {
        private readonly VehicleQuery VehicleQuery;
        private readonly VehicleToVehicleResourceMapper Mapper;

        public VehicleController(VehicleQuery vehicleQuery, VehicleToVehicleResourceMapper mapper)
        {
            VehicleQuery = vehicleQuery;
            Mapper = mapper;
        }

        public VehicleResource ReadVehicle(string vin)
        {
            VehicleRootEntity entity = VehicleQuery.FindByVin(new Vin(vin));
            return Mapper.MapVehicleToVehicleResource(entity);
        }
    }
}
