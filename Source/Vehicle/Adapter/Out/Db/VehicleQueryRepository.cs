using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.Out;

namespace clean_architecture_mapping_demo.Source.Vehicle.Adapter.Out.Db
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

            VehicleDbEntity vehicleDbEntity = new VehicleDbEntity();
            vehicleDbEntity.Vin = "WP0ZZZ99ZTS392155";
            vehicleDbEntity.LicensePlate = "ES-EM 385";
            vehicleDbEntity.Mileage = 100000.00;
            return Mapper.MapVehicleDbEntityToVehicle(vehicleDbEntity);
        }

        public VehicleRootEntity FindVehicleByVin(Vin vin)
        {
            VehicleDbEntity dbEntity = FindVehicleDbEntity(vin);
            return Mapper.MapVehicleDbEntityToVehicle(dbEntity);
        }

        private VehicleDbEntity FindVehicleDbEntity(Vin vin)
        {
            //make sql stuff

            VehicleDbEntity vehicleDbEntity = new VehicleDbEntity();
            vehicleDbEntity.Vin = vin.Value;
            vehicleDbEntity.LicensePlate = "ES-EM 385";
            vehicleDbEntity.Mileage = 100000.00;
            return vehicleDbEntity;
        }
    }
}
