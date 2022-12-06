

namespace Hexacleanws.Vehicle.Domain.Model
{
    public class VehicleMasterData
	{
		public VehicleModel VehicleModel { get; }
		public SerialNumber SerialNumber { get; }
		public MileageUnit MileageUnit { get; }
		public VehicleMasterData(VehicleModel vehicleModel, SerialNumber serialNumber, MileageUnit mileageUnit)
        {
            VehicleModel = vehicleModel;
            SerialNumber = serialNumber;
            MileageUnit = mileageUnit;
            Validate();
        }

        private void Validate()
        {

            if (VehicleModel == null || SerialNumber == null || MileageUnit == null)
            {
                throw new Exception("VehicleModel, SerialNumber and / or MileageUnit are null");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is VehicleMasterData data &&
                   EqualityComparer<SerialNumber>.Default.Equals(SerialNumber, data.SerialNumber);
        }
    }
}

