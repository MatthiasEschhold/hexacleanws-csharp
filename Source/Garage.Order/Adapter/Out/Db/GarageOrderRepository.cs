using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model;
using clean_architecture_mapping_demo.Source.Garage.Order.UseCase.Out;

namespace clean_architecture_mapping_demo.Source.Garage.Order.Adapter.Out.Db
{
    public class GarageOrderRepository : GarageOrderDbQuery, GarageOrderDbCommand
    {
        public GarageOrder FindGarageOrderByOrderNumber(OrderNumber orderNumber)
        {
            throw new NotImplementedException();
        }

        public GarageOrder save(GarageOrder garageOrder)
        {
            throw new NotImplementedException();
        }
    }
}
