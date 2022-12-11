using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.Adapter.Out.db
{
    public class VehicleToVehicleDbEntityMapper
    {
        public VehicleRootEntity MapVehicleDbEntityToVehicle(VehicleDbEntity dbEntity)
        {
            return new VehicleRootEntity(new Vin(dbEntity.Vin), null);
        }
    }
}
