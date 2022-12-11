using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Source.Vehicle.UseCase.Out;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Domain.Service
{
    public class VehicleQueryService : VehicleQuery
    {
        private readonly VehicleDbQuery DbQuery;
        private readonly FetchVehicleMasterData FetchVehicleMasterData;

        public VehicleQueryService(VehicleDbQuery dbQuery, FetchVehicleMasterData fetchVehicleMasterData)
        {
            DbQuery = dbQuery;
            FetchVehicleMasterData = fetchVehicleMasterData;
        }

        public VehicleRootEntity FindByLicensePlate(LicensePlate licensePlate)
        {
            VehicleRootEntity rootEntity = DbQuery.FindByLicensePlate(licensePlate);
            rootEntity.AddVehicleMasterData(FetchVehicleMasterData.Fetch(rootEntity.Vin));
            return rootEntity;
        }

        public VehicleRootEntity FindByVin(Vin vin)
        {
            VehicleMasterData vehicleMasterData = FetchVehicleMasterData.Fetch(vin);
            VehicleRootEntity vehicle = DbQuery.FindVehicleByVin(vin);
            vehicle.AddVehicleMasterData(vehicleMasterData);
            return vehicle;
        }


    }
}
