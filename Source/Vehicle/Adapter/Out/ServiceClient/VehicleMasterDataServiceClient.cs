using AutoMapper;

using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataServiceClient : FetchVehicleMasterData
    {
        private static readonly MapperConfiguration Config = new(cfg => {
            cfg.AddProfile<VehicleMasterDataToVehicleDataDtoMapper>();
        });

        private Mapper mapper;

        public VehicleMasterDataServiceClient()
        {
            mapper = new Mapper(Config);
        }

        public VehicleMasterDataDomainDto Fetch(Vin vin)
        {
            //call a external service
            //make http client stuff
            return mapper.Map<VehicleMasterData>(SimulatedThirdPartyServiceCallForVehicleDataDto(vin));
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
