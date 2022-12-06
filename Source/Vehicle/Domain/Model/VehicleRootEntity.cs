namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class VehicleRootEntity
    {
        public Vin Vin { get; }
        public VehicleMotionData VehicleMotionData { get; }
        public VehicleMasterData VehicleMasterData { get; private set; }
        public bool Has2GSupport { get; private set; }

        public VehicleRootEntity(Vin vin, VehicleMotionData vehicleMotionData)
        {
            Vin = vin;
            VehicleMotionData = vehicleMotionData;
            Validate();
        }

        public VehicleRootEntity(Vin vin, VehicleMotionData vehicleMotionData, VehicleMasterData vehicleMasterData)
        {
            Vin = vin;
            VehicleMotionData = vehicleMotionData;
            VehicleMasterData = vehicleMasterData;
            Validate();
            ValidateVehicleMasterData();
            determineHas2GSupport(VehicleMasterData.EquipmentList);
        }

        public void AddVehicleMasterData(VehicleMasterData vehicleMasterData)
        {
            VehicleMasterData = vehicleMasterData;
            ValidateVehicleMasterData();
            determineHas2GSupport(VehicleMasterData.EquipmentList);
        }

        private void determineHas2GSupport(List<Equipment> equipmentList)
        {
            Has2GSupport = false;
            foreach (Equipment e in equipmentList)
            {
                if (e.Code.Value.Equals("GS200"))
                {
                    Has2GSupport = true;
                    break;
                }
            }

        }

        private void ValidateVehicleMasterData()
        {
            if (VehicleMasterData == null)
            {
                throw new Exception("Vehicle master data is not valid!");
            }
        }

        private void Validate()
        {
            if (Vin == null || VehicleMotionData == null)
            {
                throw new Exception("Vin and / or vehicle motion data are not valid");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is VehicleRootEntity entity &&
                   EqualityComparer<Vin>.Default.Equals(Vin, entity.Vin);
        }
    }
}
