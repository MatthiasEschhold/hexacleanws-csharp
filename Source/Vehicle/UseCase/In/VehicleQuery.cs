using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.In
{
    public interface VehicleQuery
    {
        VehicleRootEntity FindByVin(Vin vin);
    }
}
