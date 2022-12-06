using System.Text.RegularExpressions;

namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
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
            Regex equipmentCodeRegex = new Regex(@"[A-Z]{2}[0-9]{3}");
            if (!equipmentCodeRegex.IsMatch(Value))
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

