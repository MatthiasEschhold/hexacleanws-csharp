using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Adapter.Out
{
    public class VehicleRepository : VehicleDbQuery
    {
        private readonly VehicleToVehicleDbEntityMapper Mapper;

        public VehicleRepository(VehicleToVehicleDbEntityMapper mapper)
        {
            Mapper = mapper;
        }

        public VehicleRootEntity FindVehicleByVin(Vin vin)
        {
            return Mapper.MapVehicleDbEntityToVehicle(FindVehicleDbEntity(vin));
        }

        private VehicleDbEntity FindVehicleDbEntity(Vin vin)
        {
            VehicleDbEntity dbEntity = new VehicleDbEntity();
            dbEntity.Vin = vin.Value;
            return dbEntity;
        }

    }
}
