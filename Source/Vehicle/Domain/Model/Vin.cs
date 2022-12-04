using System.Text.RegularExpressions;

namespace Hexacleanws.Vehicle.Domain.Model
{
    public class Vin
    {
        public String value { get; }

        public Vin(String value)
        {
            this.value = value;
            this.Validate();
        }

        private void Validate()
        {
            string vinPattern = @"(?=.*\d|=.*[A-Z])(?=.*[A-Z])[A-Z0-9]{17}";
            Regex vinRegex = new Regex(vinPattern);
            if (!vinRegex.IsMatch(this.value))
            {
                throw new Exception("Vin is not valid!");
            }
        }
    }
}
