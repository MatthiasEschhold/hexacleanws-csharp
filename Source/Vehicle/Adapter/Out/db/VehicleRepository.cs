using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Adapter.Out.db
{
    public class VehicleRepository : VehicleDbQuery
    {
        private readonly VehicleToVehicleDbEntityMapper Mapper;

        private const string LICENPLATE_TEST_VALUE = "ES-EM 385";
        private const double MILEAGE_TEST_VALUE = 100000;

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
