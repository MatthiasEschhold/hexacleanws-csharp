
using Hexacleanws.Source.Garage.Order.Domain.Command;
using Hexacleanws.Source.Garage.Order.Domain.Model;
using Hexacleanws.Source.Garage.Order.UseCase.In;
using Hexacleanws.Source.Garage.Order.UseCase.Out;

namespace Hexacleanwso.Source.Garage.Order.Domain.Service
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
