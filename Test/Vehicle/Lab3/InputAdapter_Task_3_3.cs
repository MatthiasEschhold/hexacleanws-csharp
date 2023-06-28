/*using Hexacleanws.Source.Vehicle.Adapter.In;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Moq;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Vehicle.Lab3
{
    public class InputAdapter_Task_3_3 : BaseTest
    {
        void vehicle_controller_should_return_a_valid_vehicle()
        {
            var vehicleQueryMock = new Mock<VehicleQuery>();
            VehicleRootEntity vehicle = CreateVehicle();
            vehicleQueryMock.Setup(vq => vq.FindByVin(new Vin(VIN))).Returns(vehicle);


            VehicleResource actualVehicleResource = new VehicleController(vehicleQueryMock.Object, new VehicleToVehicleResourceMapper()).ReadVehicle(VIN);
            Assert.Equal(vehicle.Vin.Value, actualVehicleResource.Vin);
        }

    }
}*/
