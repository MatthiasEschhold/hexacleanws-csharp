using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.Domain.dto
{
    public class VehicleMasterDataDomainDto
    {
        public VehicleModel VehicleModel { get; }
        public SerialNumber SerialNumber { get; }
        public MileageUnit MileageUnit { get; }

        public List<string> EquipmentCodes { get; }

        public VehicleMasterDataDomainDto(List<string> equipmentCodes, VehicleModel vehicleModel, SerialNumber serialNumber, MileageUnit mileageUnit)
        {
            VehicleModel = vehicleModel;
            SerialNumber = serialNumber;
            MileageUnit = mileageUnit;
            EquipmentCodes = equipmentCodes;
        }
    }
}
