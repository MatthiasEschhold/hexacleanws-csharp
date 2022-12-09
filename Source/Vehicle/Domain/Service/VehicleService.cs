using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Source.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Domain.Service
{
    public class VehicleService : VehicleQuery
    {
        private readonly VehicleDbQuery vehicleDbQuery;

        public VehicleService(VehicleDbQuery vehicleDbQuery)
        {
            this.vehicleDbQuery = vehicleDbQuery;
        }

        public VehicleRootEntity FindByVin(Vin vin)
        {
            return new VehicleRootEntity(new Vin("WP0ZZZ99ZTS392155"));
        }
    }
}
