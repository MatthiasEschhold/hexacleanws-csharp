

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleDataDto
    {


        public SalesInformationDto SalesInformation { get; set; }
        public VehicleDealerHistoryDto VehicleDealerHistory { get; set; }
        public string VinOrFin { get; set; }
        public string Baumuster { get; set; }
        public string BaumusterDescription { get; set; }
        public string SerialNumber { get; set; }
        public string MileageUnit { get; set; }
        public List<EquipmentListDto> EquipmentList { get; set; }
    }



}
