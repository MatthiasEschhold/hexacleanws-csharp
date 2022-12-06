using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Command;
using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Garage.Order.UseCase.In
{
    public interface GarageOrderCommand
    {
        GarageOrder create(CreateGarageOrderCommand createGarageOrderCommand);
        GarageOrder update(UpdateGarageOrderCommand updateGarageOrderCommand);
    }
}
