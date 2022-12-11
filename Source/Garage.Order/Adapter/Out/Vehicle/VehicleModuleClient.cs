
using Hexacleanws.Source.Garage.Order.Domain.Model;
using Hexacleanws.Source.Garage.Order.UseCase.Out;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;

namespace Hexacleanws.Source.Garage.Order.Adapter.Out.Vehicle
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
