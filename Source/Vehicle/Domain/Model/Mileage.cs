
namespace Hexacleanws.Vehicle.Domain.Model
{
	public class Mileage
	{
		public Double Value { get; }
		public Mileage(Double value)
        {
            this.Value = value;
            Validate();
        }

        private void Validate()
        {
            if (this.Value < 0)
            {
                throw new Exception("Mileage is not valid");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Mileage mileage &&
                   Value == mileage.Value;
        }
    }
}

