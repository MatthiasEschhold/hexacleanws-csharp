using AutoMapper;
using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Adapter.Out.Db
{
    public class VehicleToVehicleDbEntityMapper
    {
        public VehicleRootEntity MapVehicleDbEntityToVehicle(VehicleDbEntity dbEntity)
        {
            return new VehicleRootEntity(new Vin(dbEntity.Vin));
        }
    }
}
