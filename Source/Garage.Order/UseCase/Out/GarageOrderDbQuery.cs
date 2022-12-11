
using Hexacleanws.Source.Garage.Order.Domain.Model;

namespace Hexacleanws.Source.Garage.Order.UseCase.Out
{
    public interface GarageOrderDbQuery
    {
        GarageOrder FindGarageOrderByOrderNumber(OrderNumber orderNumber);
    }
}
