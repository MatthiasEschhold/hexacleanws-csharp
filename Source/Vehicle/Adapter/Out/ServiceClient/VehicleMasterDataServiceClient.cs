using AutoMapper;
using Hexacleanws.Vehicle.Adapter.Out.Db;
using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataServiceClient : FetchVehicleMasterData
    {
        private static readonly MapperConfiguration Config = new(cfg => {
            cfg.AddProfile<VehicleMasterDataToVehicleDataDtoKapper>();
        });

        private Mapper mapper;

        public VehicleMasterDataServiceClient()
        {
            mapper = new Mapper(Config);
        }

        public VehicleRootEntity Find(Vin vin)
        {
            var vehicleDto = new VehicleDataDto();
            //call from a external service
            return mapper.Map<VehicleRootEntity>(vehicleDto);
            throw new NotImplementedException();
        }
    }
}
