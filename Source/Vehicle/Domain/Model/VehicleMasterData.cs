namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class VehicleMasterData
    {
        public List<Equipment> EquipmentList { get; }
        public VehicleModel VehicleModel { get; }
        public SerialNumber SerialNumber { get; }
        public MileageUnit MileageUnit { get; }
        public VehicleMasterData(List<Equipment> equipmentList, VehicleModel vehicleModel, SerialNumber serialNumber, MileageUnit mileageUnit)
        {
            EquipmentList = equipmentList;
            VehicleModel = vehicleModel;
            SerialNumber = serialNumber;
            MileageUnit = mileageUnit;
            Validate();
        }

        private void Validate()
        {
            if (EquipmentList == null || EquipmentList.Count == 0)
            {
                throw new Exception("Equipment list should not null or empty");
            }

            if (VehicleModel == null || SerialNumber == null || MileageUnit == null)
            {
                throw new Exception("One or more of VehicleModel, SerialNumber oer MileageUnit are null");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is VehicleMasterData data &&
                   EqualityComparer<SerialNumber>.Default.Equals(SerialNumber, data.SerialNumber);
        }
    }
}

