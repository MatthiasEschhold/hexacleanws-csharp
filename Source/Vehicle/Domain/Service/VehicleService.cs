using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Domain.Service
{
    public class VehicleService
    {
        
        public VehicleRootEntity FindByVin(Vin vin)
        {
            return new  (new Vin("WP0ZZZ99ZTS392155"));
        }

    }
}
