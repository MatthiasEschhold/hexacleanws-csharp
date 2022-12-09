using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;

namespace Hexacleanws.Source.Vehicle.Adapter.In
{
    public class VehicleController
    {
        private readonly VehicleQuery vehicleQuery;
        public VehicleRootEntity ReadVehicle(string vin)
        {
            return vehicleQuery.FindByVin(new Vin(vin));
        }
    }
}
