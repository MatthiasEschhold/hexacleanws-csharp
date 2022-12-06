
using Hexacleanws.Vehicle.Domain.dto;
using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataServiceClient : FetchVehicleMasterData
    {
        private readonly VehicleMasterDataToVehicleDataDtoMapper Mapper;
        public VehicleMasterDataServiceClient(VehicleMasterDataToVehicleDataDtoMapper mapper)
        {
            Mapper = mapper;
        }

        public VehicleMasterDataDomainDto Fetch(Vin vin)
        {
            //call a external service
            //make http client stuff
            return Mapper.MapVehicleDataDtoToVehicleMasterData(SimulatedThirdPartyServiceCallForVehicleDataDto(vin));
        }

        private VehicleDataDto SimulatedThirdPartyServiceCallForVehicleDataDto(Vin vin)
        {
            var vehicleDto = new VehicleDataDto();
            vehicleDto.BaumusterDescription = "Super Family Van";
            vehicleDto.SerialNumber = "0123456789";
            vehicleDto.Baumuster = "Van";
            vehicleDto.VinOrFin = vin.Value;
            return vehicleDto;
        }
    }
}
