
using Hexacleanws.Source.Garage.Order.Domain.Command;
using Hexacleanws.Source.Garage.Order.Domain.Model;

namespace Hexacleanws.Source.Garage.Order.UseCase.In
{
    public interface GarageOrderCommand
    {
        GarageOrder create(CreateGarageOrderCommand createGarageOrderCommand);
        GarageOrder update(UpdateGarageOrderCommand updateGarageOrderCommand);
    }
}
