namespace Hexacleanws.Source.Vehicle.Domain.Model

{
    public class VehicleRootEntity
    {
        public Vin Vin { get; }
        public VehicleMotionData VehicleMotionData { get; }
        public VehicleMasterData VehicleMasterData { get; private set; }

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
            VehicleMasterData= vehicleMasterData;
            Validate();
            ValidateVehicleMasterData();
        }

        public void AddVehicleMasterData(VehicleMasterData vehicleMasterData)
        {
            VehicleMasterData = vehicleMasterData;
            ValidateVehicleMasterData();
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

        public override int GetHashCode()
        {
            return HashCode.Combine(Vin);
        }
    }
}
