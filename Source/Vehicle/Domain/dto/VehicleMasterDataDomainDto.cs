using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Domain.dto
{
    public class VehicleMasterDataDomainDto
    {
        public List<string> EquipmentCodes { get; }
        public VehicleModel VehicleModel { get; }
        public SerialNumber SerialNumber { get; }
        public MileageUnit MileageUnit { get; }

        public VehicleMasterDataDomainDto(List<string> equipmentcodes, VehicleModel vehicleModel, SerialNumber serialNumber, MileageUnit mileageUnit)
        {
            EquipmentCodes = equipmentcodes;
            VehicleModel = vehicleModel;
            SerialNumber = serialNumber;
            MileageUnit = mileageUnit;
        }
    }
}

