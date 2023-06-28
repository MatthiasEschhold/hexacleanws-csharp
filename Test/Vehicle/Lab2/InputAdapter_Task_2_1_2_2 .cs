/*using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Test;
using Moq;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab2
{

    public class InputAdapter_Task_2_1_2_2 : BaseTest
    {
        [Fact]
        public void vehicle_controller_should_return_a_valid_vehicle()
        {
            var vehicleQueryMock = new Mock<VehicleQuery>();
            VehicleRootEntity vehicle = CreateVehicle();
            vehicleQueryMock.Setup(vq => vq.FindByVin(new Vin(VIN))).Returns(vehicle);

            var actualVehicle = new VehicleController(vehicleQueryMock.Object).ReadVehicle(VIN);

            Assert.Equal(vehicle, actualVehicle);
        }


        protected VehicleRootEntity CreateVehicle()
        {
            return new VehicleRootEntity(new Vin("WP0ZZZ99ZTS392155"));
        }

    }
}*/
