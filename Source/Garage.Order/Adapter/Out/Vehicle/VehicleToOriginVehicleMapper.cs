using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Garage.Order.Adapter.Out.Vehicle
{
    public class VehicleToOriginVehicleMapper
    {
        public VehicleData MapVehicleRootEntityToVehicleData(VehicleRootEntity rootEntity)
        {
            return new VehicleData(rootEntity.VehicleMotionData.LicensePlate.Value, rootEntity.VehicleMotionData.Mileage.Value);
        }
    }
}
