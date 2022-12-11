using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.Adapter.Out
{
    public class VehicleToVehicleDbEntityMapper
    {
        VehicleRootEntity MapVehicleDbEntityToVehicle(VehicleDbEntity dbEntity)
        {
            return new VehicleRootEntity(new Vin(dbEntity.Vin));
        }
    }
}
