
using System.Text.RegularExpressions;

namespace Hexacleanws.Source.Vehicle.Domain.Model

{
    public class SerialNumber
	{
		public String Value { get; }
		public SerialNumber(String value)
        {
            this.Value = value;
            Validate();
        }

        private void Validate()
        {
            Regex serialNumberRegex = new Regex(@"[0-9]{10}");
            if (!serialNumberRegex.IsMatch(Value))
            {
                throw new Exception("Serial number is not valid");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is SerialNumber number &&
                   Value == number.Value;
        }
    }
}

