using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Domain.Service
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

        public VehicleRootEntity FindByVin(Vin vin)
        {
            VehicleRootEntity rootEntity = DbQuery.FindVehicleByVin(vin);
            rootEntity.AddVehicleMasterData(FetchVehicleMasterData.Fetch(vin));
            return rootEntity;
        }
    }
}
