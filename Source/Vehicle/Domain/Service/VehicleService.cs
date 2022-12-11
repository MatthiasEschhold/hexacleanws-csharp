using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Source.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Domain.Service
{
    public class VehicleService : VehicleQuery
    {
        private readonly VehicleDbQuery VehicleDbQuery;

        public VehicleService(VehicleDbQuery vehicleDbQuery)
        {
            VehicleDbQuery = vehicleDbQuery;
        }

        public VehicleRootEntity FindByVin(Vin vin)
        {
            VehicleRootEntity vehicle = VehicleDbQuery.FindVehicleByVin(vin);
            return vehicle;
        }
    }
}
