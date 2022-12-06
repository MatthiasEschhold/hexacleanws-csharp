
using clean_architecture_mapping_demo.Source.Vehicle.Adapter.In.Web;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.In;
using clean_architecture_mapping_demo.Test;
using Moq;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab3
{
    public class InputAdapter_Task_3_3 : BaseTest
    {
        [Fact]
        void vehicle_controller_should_return_a_valid_vehicle()
        {
            var vehicleCommandMock = new Mock<VehicleCommand>();

            var vehicleQueryMock = new Mock<VehicleQuery>();
            VehicleRootEntity vehicle = CreateVehicle();
            vehicleQueryMock.Setup(vq => vq.FindByVin(new Vin(VIN))).Returns(vehicle);


            VehicleResource actualVehicleResource = CreateVehicleController(vehicleQueryMock, vehicleCommandMock).GetVehicle(VIN);
            Assert.Equal(vehicle.Vin.Value, actualVehicleResource.Vin);
        }

        private VehicleController CreateVehicleController(Mock<VehicleQuery> vehicleQuery,
            Mock<VehicleCommand> vehicleCommand)
        {
            return new VehicleController(vehicleQuery.Object, vehicleCommand.Object, new VehicleToVehicleResourceMapper());
        }
    }
}

