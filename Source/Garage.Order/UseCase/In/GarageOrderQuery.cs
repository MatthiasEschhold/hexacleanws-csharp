using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Garage.Order.UseCase.In
{
    public interface GarageOrderQuery
    {
        GarageOrder FindByOrderNumber(OrderNumber orderNumber);
    }
}
