
using Hexacleanws.Source.Garage.Order.Domain.Model;

namespace Hexacleanws.Source.Garage.Order.UseCase.In
{
    public interface GarageOrderQuery
    {
        GarageOrder FindByOrderNumber(OrderNumber orderNumber);
    }
}
