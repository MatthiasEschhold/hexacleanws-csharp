using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.Out
{
    public interface VehicleDbCommand
    {
        VehicleRootEntity Save(VehicleRootEntity vehicle);
    }
}
