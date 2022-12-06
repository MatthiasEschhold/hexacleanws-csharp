using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Garage.Order.UseCase.Out
{
    public interface GarageOrderDbCommand
    {
        GarageOrder save(GarageOrder garageOrder);
    }
}
