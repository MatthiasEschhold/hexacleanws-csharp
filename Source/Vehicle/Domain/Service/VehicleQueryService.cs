using AutoMapper;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.In;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.Out;

namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Service
{
    public class VehicleQueryService : VehicleQuery, FetchVehicleByLicensePlate
    {
        private readonly VehicleDbQuery DbQuery;
        private readonly FetchVehicleMasterData FetchVehicleMasterData;

        public VehicleQueryService(VehicleDbQuery dbQuery, FetchVehicleMasterData fetchVehicleMasterData)
        {
            DbQuery = dbQuery;
            FetchVehicleMasterData = fetchVehicleMasterData;
        }

        public VehicleRootEntity FetchByLicensePlate(LicensePlate licensePlate)
        {
            VehicleRootEntity rootEntity = DbQuery.FindByLicensePlate(licensePlate);
            rootEntity.AddVehicleMasterData(FetchVehicleMasterData.Fetch(rootEntity.Vin));
            return rootEntity;
        }

        public VehicleRootEntity FindByVin(Vin vin)
        {
            VehicleRootEntity rootEntity = DbQuery.FindVehicleByVin(vin);
            rootEntity.AddVehicleMasterData(FetchVehicleMasterData.Fetch(vin));
            return rootEntity;
        }
    }
}
