

using Hexacleanws.Source.Vehicle.Adapter.In;
using Hexacleanws.Source.Vehicle.Adapter.In.Web;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Test;
using Moq;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Vehicle.Lab4
{
    public class InputAdapter_Task_4_2 : BaseTest
    {
        [Fact]
        public void vehicle_controller_should_return_a_valid_vehicle()
        {
            var vehicleQueryMock = new Mock<VehicleQuery>();
            VehicleRootEntity vehicle = CreateVehicle();
            vehicleQueryMock.Setup(vq => vq.FindByVin(new Vin(VIN))).Returns(vehicle);

            var actualVehicle = new VehicleController(vehicleQueryMock.Object, new VehicleToVehicleResourceMapper()).ReadVehicle(VIN);

            Assert.Equal(vehicle.Vin.Value, actualVehicle.Vin);
            Assert.Equal(vehicle.VehicleMasterData.MileageUnit.Value.ToString(), actualVehicle.MileageUnit);
            Assert.Equal(vehicle.VehicleMasterData.SerialNumber.Value, actualVehicle.SerialNumber);
            Assert.Equal(vehicle.VehicleMasterData.VehicleModel.ModelType, actualVehicle.VehicleModelType);
            Assert.Equal(vehicle.VehicleMasterData.VehicleModel.ModelDescription, actualVehicle.VehicleModelDescription);
            Assert.Equal(vehicle.VehicleMotionData.Mileage.Value, actualVehicle.Mileage);
            Assert.Equal(vehicle.VehicleMotionData.LicensePlate.Value, actualVehicle.LicensePlate);
        }

    }
}

