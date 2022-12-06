using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model;
using clean_architecture_mapping_demo.Source.Garage.Order.UseCase.In;
using clean_architecture_mapping_demo.Source.Garage.Order.UseCase.Out;

namespace clean_architecture_mapping_demo.Source.Garage.Order.Domain.Service
{
    public class GarageOrderQueryService : GarageOrderQuery
    {
        private readonly GarageOrderDbQuery dbQuery;

        public GarageOrderQueryService(GarageOrderDbQuery dbQuery)
        {
            this.dbQuery = dbQuery;
        }

        public GarageOrder FindByOrderNumber(OrderNumber orderNumber)
        {
            return dbQuery.FindGarageOrderByOrderNumber(orderNumber);
        }
    }
}
