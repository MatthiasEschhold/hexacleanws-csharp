namespace clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model
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
