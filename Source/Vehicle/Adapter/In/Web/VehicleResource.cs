
namespace Hexacleanws.Vehicle.Adapter.In.Web
{
    public class VehicleResource
    {
        public string Vin { get; set; }
        public string LicensePlate { get; set; }
        public double Mileage { get; set; } 
        public string MileageUnit { get; set; }

        public string VehicleModelName { get; set; }
        public string VehicleModelDescription { get; set; }
        public string SerialNumber { get; set; }
        public List<EquipmentResource> equipmentList { get; set; }

    }
}
