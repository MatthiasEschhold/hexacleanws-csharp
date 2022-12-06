using System;

namespace clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Model
{
    public class Vehicle
    {
        public string Vin { get; }
        public string VehicleModelDescription { get; }
        public string VehicleModelName { get; }
        public bool Has2GSupport { get; }

        public Vehicle(string vin, string vehicleModelDescription, string vehicleModelName, bool has2GSupport)
        {
            Vin = vin;
            VehicleModelDescription = vehicleModelDescription;
            VehicleModelName = vehicleModelName;
            Has2GSupport = has2GSupport;
        }
    }
}
