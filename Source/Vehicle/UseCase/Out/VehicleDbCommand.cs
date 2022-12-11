using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.UseCase.Out
{
    public interface VehicleDbCommand
    {
        VehicleRootEntity Save(VehicleRootEntity vehicle);
    }
}
