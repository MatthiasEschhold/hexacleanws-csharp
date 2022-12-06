namespace clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model
{
    public class Vehicle
    {
        public String LicensePlate { get; }
        private String Vin { get; }

        public Vehicle(string licensePlate, string vin)
        {
            LicensePlate = licensePlate;
            Vin = vin;
        }
    }
}
