
using Hexacleanws.Source.Garage.Order.Domain.Model;
using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Garage.Order.Adapter.Out.Vehicle
{
    public class VehicleToOriginVehicleMapper
    {
        public VehicleData MapVehicleRootEntityToVehicleData(VehicleRootEntity rootEntity)
        {
            return new VehicleData(rootEntity.VehicleMotionData.LicensePlate.Value, rootEntity.VehicleMotionData.Mileage.Value);
        }
    }
}
