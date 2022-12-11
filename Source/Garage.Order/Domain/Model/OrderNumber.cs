namespace Hexacleanws.Source.Garage.Order.Domain.Model
{
    public class OrderNumber
    {
        public String Value { get; }

        public OrderNumber(string value)
        {
            Value = value;
        }
    }
}
