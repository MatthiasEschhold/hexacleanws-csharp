using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.Out
{
    public interface VehicleDbQuery
    {
        VehicleRootEntity FindVehicleByVin(Vin  vin);
    }
}
