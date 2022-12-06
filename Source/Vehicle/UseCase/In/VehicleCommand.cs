using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Vehicle.UseCase.In
{
    public interface VehicleCommand
    {
        VehicleRootEntity Create(VehicleRootEntity vehicle);
        VehicleRootEntity Update(Vin vin, VehicleMotionData vehicleMotionData);
    }
}
