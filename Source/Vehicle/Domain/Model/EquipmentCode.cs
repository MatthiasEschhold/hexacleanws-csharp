using System.Text.RegularExpressions;

namespace Hexacleanws.Source.Vehicle.Domain.Model
{
    public class EquipmentCode
    {
        public string Value { get; }

        public EquipmentCode(string value)
        {
            Value = value;
            Validate();
        }

        private void Validate()
        {
            string vinPattern = @"[A-Z]{2}[0-9]{3}";
            Regex vinRegex = new Regex(vinPattern);
            if (!vinRegex.IsMatch(Value))
            {
                throw new Exception("EquipmentCode is not valid!");
            }
        }
    }
}