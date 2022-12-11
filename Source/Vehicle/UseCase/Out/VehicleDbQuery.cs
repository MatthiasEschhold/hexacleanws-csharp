using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.UseCase.Out
{
    public interface VehicleDbQuery
    {
        VehicleRootEntity FindVehicleByVin(Vin vin);
        VehicleRootEntity FindByLicensePlate(LicensePlate licensePlate);
    }
}
