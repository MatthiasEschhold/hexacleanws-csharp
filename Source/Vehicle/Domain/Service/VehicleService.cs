using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Source.Vehicle.UseCase.Out;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Domain.Service
{
    public class VehicleService : VehicleQuery
    {
        private readonly VehicleDbQuery VehicleDbQuery;
        private readonly FetchVehicleMasterData FetchVehicleMasterData;

        public VehicleService(VehicleDbQuery vehicleDbQuery, FetchVehicleMasterData fetchVehicleMasterData)
        {
            VehicleDbQuery = vehicleDbQuery;
            FetchVehicleMasterData = fetchVehicleMasterData;
        }

        public VehicleRootEntity FindByVin(Vin vin)
        {
            VehicleMasterData vehicleMasterData = FetchVehicleMasterData.Fetch(vin);
            VehicleRootEntity vehicle = VehicleDbQuery.FindVehicleByVin(vin);
            vehicle.AddVehicleMasterData(vehicleMasterData);
            return vehicle;
        }
    }
}
