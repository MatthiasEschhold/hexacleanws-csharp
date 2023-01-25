namespace Hexacleanws.Source.Vehicle.Domain.Model
{
    public class VehicleRootEntity
    {
        public Vin Vin { get;  }

        public VehicleRootEntity(Vin vin)
        {
            Vin = vin ?? throw new Exception(nameof(vin));
        }

        public override bool Equals(object? obj)
        {
            return obj is VehicleRootEntity entity &&
                   EqualityComparer<Vin>.Default.Equals(Vin, entity.Vin);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Vin);
        }
    }
}
