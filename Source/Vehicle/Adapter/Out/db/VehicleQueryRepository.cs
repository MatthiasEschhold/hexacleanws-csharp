using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Adapter.Out.db
{
    public class VehicleQueryRepository : VehicleDbQuery
    {
        private readonly VehicleToVehicleDbEntityMapper Mapper;

        public VehicleQueryRepository(VehicleToVehicleDbEntityMapper mapper)
        {
            Mapper = mapper;
        }

        public VehicleRootEntity FindByLicensePlate(LicensePlate licensePlate)
        {
            //make sql stuff

            return Mapper.MapVehicleDbEntityToVehicle(CreateVehicleDbEntity(licensePlate.Value));
        }


        public VehicleRootEntity FindVehicleByVin(Vin vin)
        {
            return Mapper.MapVehicleDbEntityToVehicle(CreateVehicleDbEntity(vin.Value));
        }

        private VehicleDbEntity CreateVehicleDbEntity(String vin)
        {
            VehicleDbEntity dbEntity = new VehicleDbEntity();
            dbEntity.Vin = "WP0ZZZ99ZTS392155";
            dbEntity.LicensePlate = "ES-EM 385";
            dbEntity.Mileage = 100000;
            return dbEntity;
        }

    }
}
