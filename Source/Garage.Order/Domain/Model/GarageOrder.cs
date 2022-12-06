namespace clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model
{
    public class GarageOrder
    {
        public VehicleData Vehicle { get; }
        public OrderNumber OrderNumber { get; }
        public OrderPosition OrderPosition { get; }

        public GarageOrder(VehicleData vehicle, OrderNumber orderNumber, OrderPosition orderPosition)
        {
            Vehicle = vehicle;
            OrderNumber = orderNumber;
            OrderPosition = orderPosition;
        }
    }
}
