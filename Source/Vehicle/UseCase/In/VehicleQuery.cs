using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.UseCase.In
{
    public interface VehicleQuery
    {
        VehicleRootEntity FindByVin(Vin vin);
    }
}
