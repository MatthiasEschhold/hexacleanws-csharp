using Hexacleanws.Source.Vehicle.Domain.dto;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Source.Vehicle.UseCase.Out;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Domain.Service
{
    public class VehicleQueryService : VehicleQuery
    {
        private readonly VehicleDbQuery VehicleDbQuery;
        private readonly FetchVehicleMasterData FetchVehicleMasterData;

        public VehicleQueryService(VehicleDbQuery vehicleDbQuery, FetchVehicleMasterData fetchVehicleMasterData)
        {
            VehicleDbQuery = vehicleDbQuery;
            FetchVehicleMasterData = fetchVehicleMasterData;
        }

        public VehicleRootEntity FindByVin(Vin vin)
        {
            VehicleMasterDataDomainDto vehicleMasterData = FetchVehicleMasterData.Fetch(vin);
            VehicleRootEntity vehicle = VehicleDbQuery.FindVehicleByVin(vin);
            vehicle.AddVehicleMasterData(new VehicleMasterData(vehicleMasterData.VehicleModel, vehicleMasterData.SerialNumber, vehicleMasterData.MileageUnit));
            vehicle.Update2GSupport(determineHas2GSupport(vehicleMasterData.EquipmentCodes));
            return vehicle;
        }

        private bool determineHas2GSupport(List<string> equipmentCodes)
        {
            foreach (String c in equipmentCodes)
            {
                if (c.Equals("GS200"))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
