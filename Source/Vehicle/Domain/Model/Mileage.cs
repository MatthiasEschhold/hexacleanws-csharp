namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class Mileage
    {
        public double Value { get; }
        public Mileage(double value)
        {
            Value = value;
            Validate();
        }

        private void Validate()
        {
            if (Value < 0)
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

