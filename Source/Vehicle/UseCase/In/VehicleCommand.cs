using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.UseCase.In
{
    public interface VehicleCommand
    {
        VehicleRootEntity Create(VehicleRootEntity vehicle);
        VehicleRootEntity Update(Vin vin, VehicleMotionData vehicleMotionData);
    }
}
