using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Command;
using clean_architecture_mapping_demo.Source.Garage.Order.Domain.Model;
using clean_architecture_mapping_demo.Source.Garage.Order.UseCase.In;
using clean_architecture_mapping_demo.Source.Garage.Order.UseCase.Out;

namespace clean_architecture_mapping_demo.Source.Garage.Order.Domain.Service
{
    public class GarageOrderCommandService : GarageOrderCommand
    {
        private readonly GarageOrderDbCommand dbCommand;

        public GarageOrderCommandService(GarageOrderDbCommand dbCommand)
        {
            this.dbCommand = dbCommand;
        }

        public GarageOrder create(CreateGarageOrderCommand createGarageOrderCommand)
        {
            throw new NotImplementedException();
        }

        public GarageOrder update(UpdateGarageOrderCommand updateGarageOrderCommand)
        {
            throw new NotImplementedException();
        }
    }
}
