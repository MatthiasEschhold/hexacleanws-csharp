
using Hexacleanws.Source.Garage.Order.Domain.Model;
using Hexacleanws.Source.Garage.Order.UseCase.Out;

namespace Hexacleanws.Source.Garage.Order.Adapter.Out.Db
{
    public class GarageOrderRepository : GarageOrderDbQuery, GarageOrderDbCommand
    {
        public GarageOrder FindGarageOrderByOrderNumber(OrderNumber orderNumber)
        {
            throw new NotImplementedException();
        }

        public GarageOrder Save(GarageOrder garageOrder)
        {
            throw new NotImplementedException();
        }
    }
}
