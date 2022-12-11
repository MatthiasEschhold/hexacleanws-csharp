
using Hexacleanws.Source.Garage.Order.Domain.Model;
using Hexacleanws.Source.Garage.Order.UseCase.In;
using Hexacleanws.Source.Garage.Order.UseCase.Out;

namespace Hexacleanws.Source.Garage.Order.Domain.Service
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
