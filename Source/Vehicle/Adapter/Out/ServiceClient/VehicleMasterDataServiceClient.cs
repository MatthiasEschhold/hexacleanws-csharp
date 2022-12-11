
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataServiceClient : FetchVehicleMasterData
    {
        private const string VEHICLE_MODEL_DESCRIPTION_TEST_VALUE = "E30 Limousine";
        private const string VEHICLE_MODEL_TYPE_TEST_VALUE = "3er";
        private const string SERIAL_NUMBER_TEST_VALUE = "0123456789";

        private readonly VehicleMasterDataToVehicleDataDtoMapper Mapper;

        public VehicleMasterDataServiceClient(VehicleMasterDataToVehicleDataDtoMapper mapper)
        {
            Mapper = mapper;
        }

        public VehicleMasterData Fetch(Vin vin)
        {
            return Mapper.MapVehicleDataDtoToVehicleMasterData(CreateVehicleDataDto());
        }

        private VehicleDataDto CreateVehicleDataDto()
        {
            VehicleDataDto vehicleDataDto= new VehicleDataDto();
            vehicleDataDto.BaumusterDescription = VEHICLE_MODEL_DESCRIPTION_TEST_VALUE;
            vehicleDataDto.Baumuster = VEHICLE_MODEL_TYPE_TEST_VALUE;
            vehicleDataDto.SerialNumber = SERIAL_NUMBER_TEST_VALUE;
            vehicleDataDto.MileageUnit = MileageUnitValue.KM.ToString();
            return vehicleDataDto;
        }
    }
}
