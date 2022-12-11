namespace Hexacleanws.Source.Vehicle.Domain.Model
{
    public class Mileage
    {
        public double Value { get; }

        public Mileage(double value)
        {
            Value = value;
            if(Value < 0)
            {
                throw new Exception("Vin is not valid!");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Mileage mileage &&
                   Value == mileage.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }

    }
}
