using System;

namespace clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Model
{
    public class VehicleData
    {
        public string Vin { get; }
        public string VehicleModelType { get; }
        public bool Has2GSupport { get; }

        public VehicleData(string vin, string vehicleModelType, bool has2GSupport)
        {
            Vin = vin;
            VehicleModelType = vehicleModelType;
            Has2GSupport = has2GSupport;
        }
    }
}
