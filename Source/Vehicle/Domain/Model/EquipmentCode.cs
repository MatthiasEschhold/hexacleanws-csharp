
using System.Text.RegularExpressions;

namespace Hexacleanws.Vehicle.Domain.Model
{
    public class EquipmentCode
    {
        public String Value { get; }

        public EquipmentCode(String value)
        {
            this.Value = value;
            Validate();
        }

        private void Validate()
        {
            Regex equipmentCodeRegex = new Regex(@"[A-Z]{2}[0-9]{3}");
            if (!equipmentCodeRegex.IsMatch(this.Value))
            {
                throw new Exception("Equipment code is not valid");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is EquipmentCode code &&
                   Value == code.Value;
        }
    }
}

