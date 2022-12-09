using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.Domain.Service
{
    public class VehicleService
    {
        public VehicleRootEntity FindByVin(Vin vin)
        {
            return new VehicleRootEntity(new Vin("WP0ZZZ99ZTS392155"));
        }
    }
}
