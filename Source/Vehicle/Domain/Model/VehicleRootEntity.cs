
using Hexacleanws.Vehicle.Domain.dto;

namespace Hexacleanws.Vehicle.Domain.Model
{
    public class VehicleRootEntity
    {
        public Vin Vin { get; }
        public VehicleMotionData VehicleMotionData { get; }
        public VehicleMasterData VehicleMasterData { get; private set; }
        public Boolean Has2GSupport { get; private set; } 

        public VehicleRootEntity(Vin vin, VehicleMotionData vehicleMotionData)
        {
            Vin = vin;
            VehicleMotionData = vehicleMotionData;
            Validate();
        }

        public VehicleRootEntity(Vin vin, VehicleMotionData vehicleMotionData, VehicleMasterData vehicleMasterData, Boolean has2GSupport)
        {
            Vin = vin;
            VehicleMotionData = vehicleMotionData;
            VehicleMasterData = vehicleMasterData;
            Has2GSupport = has2GSupport;
            Validate();
            ValidateVehicleMasterData();
        }

        public void AddVehicleMasterData(VehicleMasterDataDomainDto vehicleMasterDataDomainDto)
        {
            VehicleMasterData = new VehicleMasterData(vehicleMasterDataDomainDto.VehicleModel, vehicleMasterDataDomainDto.SerialNumber, vehicleMasterDataDomainDto.MileageUnit);
            ValidateVehicleMasterData();
            determineHas2GSupport(vehicleMasterDataDomainDto.EquipmentCodes);
        }

        private void determineHas2GSupport(List<string> equipmentCodeList)
        {
            Has2GSupport = false;
            foreach (string code in equipmentCodeList) {
                if(code.Equals("GS200"))
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
