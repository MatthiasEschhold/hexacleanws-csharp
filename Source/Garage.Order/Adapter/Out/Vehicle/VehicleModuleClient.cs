
using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model;
using clean_architecture_mapping_demo.Source.Garage.Order.UseCase.Out;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.In;

namespace clean_architecture_mapping_demo.Source.Garage.Order.Adapter.Out.Vehicle
{
    public class VehicleModuleClient : FetchVehicle
    {
        private readonly FetchVehicleByLicensePlate FindVehicle;
        private readonly VehicleToOriginVehicleMapper Mapper;

        public VehicleModuleClient(FetchVehicleByLicensePlate findVehicle, VehicleToOriginVehicleMapper mapper)
        {
            FindVehicle = findVehicle;
            Mapper = mapper;
        }

        public VehicleData FetchByLicensePlate(string licensePlate)
        {
            VehicleRootEntity vehicleRootEntity = FindVehicle.FindByLicensePlate(new LicensePlate(licensePlate));
            return Mapper.MapVehicleRootEntityToVehicleData(vehicleRootEntity);
        }
    }
}
