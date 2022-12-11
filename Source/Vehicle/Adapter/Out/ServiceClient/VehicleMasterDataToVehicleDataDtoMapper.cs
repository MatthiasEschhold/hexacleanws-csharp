using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataToVehicleDataDtoMapper
    {
        public VehicleMasterData MapVehicleDataDtoToVehicleMasterData(VehicleDataDto dto)
        {
            return new VehicleMasterData(mapToEquipmentList(dto.EquipmentList),
                new VehicleModel(dto.BaumusterDescription, dto.Baumuster), new SerialNumber(dto.SerialNumber),
mapMileageUnitValue(dto));

        }

        private static MileageUnit mapMileageUnitValue(VehicleDataDto dto)
        {
            return new MileageUnit(dto.MileageUnit == MileageUnitValue.KM.ToString() ? MileageUnitValue.KM : MileageUnitValue.MILES);
        }

        private List<Equipment> mapToEquipmentList(EquipmentListDto equipmentList)
        {
            List<Equipment> list = new List<Equipment>();
            foreach (EquipmentDto e in equipmentList.List)
            {
                list.Add(mapToEquipment(e));
            }
            return list;
        }

        private Equipment mapToEquipment(EquipmentDto dto)
        {
            return new Equipment(new EquipmentCode(dto.Code), dto.Name);
        }
    }
}
