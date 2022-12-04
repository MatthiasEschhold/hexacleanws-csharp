

using Hexacleanws.Vehicle.Source.Vehicle.Adapter.Out.ServiceClient;

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleDataDto
    {


        public SalesInformationDto? salesInformation { get; set; }
        public VehicleDealerHistoryDto? vehicleDealerHistory { get; set; }
        public string? vinOrFin { get; set; }
        public string? baumuster { get; set; }
        public string? baumusterDescription { get; set; }
        public string? serialNumber { get; set; }
        public string? mileageUnit { get; set; }
        public List<EquipmentListDto>? equipmentList { get; set; }
    }



}
