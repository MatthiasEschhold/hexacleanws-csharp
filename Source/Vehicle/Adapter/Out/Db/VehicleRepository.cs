using AutoMapper;
using Hexacleanws.Vehicle.Adapter.Out.ServiceClient;
using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Adapter.Out.Db
{
    public class VehicleRepository: VehicleDbQuery
    {

        private readonly VehicleToVehicleDbEntityMapper mapper;

        public VehicleRepository(VehicleToVehicleDbEntityMapper mapper)
        {
            this.mapper = mapper;
        }

        public VehicleRootEntity FindVehicleByVin(Vin vin)
        {
            return mapper.MapVehicleDbEntityToVehicle(FindVehicleDbEntity(vin));
        }

        private VehicleDbEntity FindVehicleDbEntity(Vin vin)
        {
            //make sql stuff

            VehicleDbEntity vehicleDbEntity = new VehicleDbEntity();
            vehicleDbEntity.Vin = vin.value;

            return vehicleDbEntity;
        }
    }
}
