using Hexacleanws.Source.Vehicle.Adapter.In.Web;

namespace Hexacleanws.Source.Vehicle.Adapter.In
{
    public class VehicleResource
    {
        public string Vin { get; set; }
        public string VehicleModelDescription { get; set; }
        public string VehicleModelType { get; set; }
        public double Mileage { get; set; }
        public string MileageUnit { get; set; } 
        public string LicensePlate { get; set; }
        public string SerialNumber { get; set; }

        public List<EquipmentResource> equipmentList { get; set; }
            
    }
}
