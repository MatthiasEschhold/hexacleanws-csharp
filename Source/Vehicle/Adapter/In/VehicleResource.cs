using Hexacleanws.Source.Vehicle.Adapter.In.Web;

namespace Hexacleanws.Source.Vehicle.Adapter.In
{
    public class VehicleResource
    {
        public string Vin { get; set; }
        public string MileageUnit { get; set; }
        public string VehicleModelName { get; set; }
        public string VehicleModelType { get; set; }
        public string SerialNumber { get; set; }
        public List<EquipmentResource> EquipmentList { get; set; }


            
    }
}
