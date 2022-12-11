
using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.UseCase.In
{
    public interface FetchVehicleByLicensePlate
    {
        VehicleRootEntity FindByLicensePlate(LicensePlate licensePlate);
    }
}
