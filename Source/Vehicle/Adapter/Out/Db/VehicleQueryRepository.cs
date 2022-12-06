
using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Adapter.Out.Db
{
    public class VehicleQueryRepository: VehicleDbQuery
    {

        private readonly VehicleToVehicleDbEntityMapper mapper;

        public VehicleQueryRepository(VehicleToVehicleDbEntityMapper mapper)
        {
            this.mapper = mapper;
        }

        public VehicleRootEntity FindVehicleByVin(Vin vin)
        {
            VehicleDbEntity dbEntity = FindVehicleDbEntity(vin);
            return mapper.MapVehicleDbEntityToVehicle(dbEntity);
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
