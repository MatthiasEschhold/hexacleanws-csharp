using Hexacleanws.Source.Vehicle.Domain.dto;
using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataToVehicleDataDtoMapper
    {
        public VehicleMasterDataDomainDto MapVehicleDataDtoToVehicleMasterData(VehicleDataDto dto)
        {
            return new VehicleMasterDataDomainDto(mapToEquipmentList(dto.EquipmentList),
                new VehicleModel(dto.BaumusterDescription, dto.Baumuster), new SerialNumber(dto.SerialNumber),
mapMileageUnitValue(dto));

        }

        private static MileageUnit mapMileageUnitValue(VehicleDataDto dto)
        {
            return new MileageUnit(dto.MileageUnit == MileageUnitValue.KM.ToString() ? MileageUnitValue.KM : MileageUnitValue.MILES);
        }

        private List<string> mapToEquipmentList(EquipmentListDto equipmentList)
        {
            List<string> list = new List<string>();
            foreach (EquipmentDto e in equipmentList.List)
            {
                list.Add(mapToEquipment(e));
            }
            return list;
        }

        private string mapToEquipment(EquipmentDto dto)
        {
            return dto.Code;
        }
    }
}
