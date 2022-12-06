
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Adapter.In.Web;
using Moq;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab4
{
    public class InputAdapter_Task_4_2 : BaseArchTest
    {
        [Fact]
        public void vehicle_controller_should_return_a_valid_vehicle()
        {
            var vehicleCommandMock = new Mock<VehicleCommand>();

            var vehicleQueryMock = new Mock<VehicleQuery>();
            VehicleRootEntity vehicle = CreateVehicle();
            vehicleQueryMock.Setup(vq => vq.FindByVin(new Vin(VIN))).Returns(vehicle);

            var actualVehicle = new VehicleController(vehicleQueryMock.Object, vehicleCommandMock.Object,
                new VehicleToVehicleResourceMapper()).GetVehicle(VIN);

            Assert.Equal(vehicle.Vin.Value, actualVehicle.Vin);
            //Assert.Equal(vehicle.VehicleMasterData.MileageUnit.Value.ToString, actualVehicle.MileageUnit);
            Assert.Equal(vehicle.VehicleMasterData.SerialNumber.Value, actualVehicle.SerialNumber);
            Assert.Equal(vehicle.VehicleMasterData.VehicleModel.ModelType, actualVehicle.VehicleModelName);
            Assert.Equal(vehicle.VehicleMasterData.VehicleModel.ModelDescription, actualVehicle.VehicleModelDescription);
            Assert.Equal(vehicle.VehicleMotionData.Mileage.Value, actualVehicle.Mileage);
            Assert.Equal(vehicle.VehicleMotionData.LicensePlate.Value, actualVehicle.LicensePlate);
        }

    }
}

