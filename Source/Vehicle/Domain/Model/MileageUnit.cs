
namespace Hexacleanws.Source.Vehicle.Domain.Model
{
	public class MileageUnit
	{
		public MileageUnitValue Value { get; }
		public MileageUnit(MileageUnitValue value)
		{
			Value = value;
		}

        public override bool Equals(object? obj)
        {
            return obj is MileageUnit unit &&
                   Value == unit.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}

