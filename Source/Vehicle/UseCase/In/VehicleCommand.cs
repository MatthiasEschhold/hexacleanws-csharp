using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.In
{
    public interface VehicleCommand
    {
        VehicleRootEntity Create(VehicleRootEntity vehicle);
        VehicleRootEntity Update(Vin vin, VehicleMotionData vehicleMotionData);
    }
}
