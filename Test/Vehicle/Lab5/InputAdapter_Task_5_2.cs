
using Hexacleanws.Source.Vehicle.Adapter.In;
using Hexacleanws.Source.Vehicle.Adapter.In.Web;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Test;
using Moq;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab5
{
    public class InputAdapter_Task_5_2 : BaseTest
    {
        [Fact]
        public void vehicle_controller_should_return_a_valid_vehicle()
        {
            var vehicleCommandMock = new Mock<VehicleCommand>();

            var vehicleQueryMock = new Mock<VehicleQuery>();
            VehicleRootEntity vehicle = CreateVehicle();
            vehicleQueryMock.Setup(vq => vq.FindByVin(new Vin(VIN))).Returns(vehicle);

            var actualVehicle = new VehicleController(vehicleQueryMock.Object, vehicleCommandMock.Object,
                new VehicleToVehicleResourceMapper()).ReadVehicle(VIN);

            Assert.Equal(vehicle.Vin.Value, actualVehicle.Vin);
            Assert.Equal(vehicle.VehicleMasterData.MileageUnit.Value.ToString(), actualVehicle.MileageUnit);
            Assert.Equal(vehicle.VehicleMasterData.SerialNumber.Value, actualVehicle.SerialNumber);
            Assert.Equal(vehicle.VehicleMasterData.VehicleModel.ModelType, actualVehicle.VehicleModelType);
            Assert.Equal(vehicle.VehicleMasterData.VehicleModel.ModelDescription, actualVehicle.VehicleModelDescription);
            Assert.Equal(vehicle.VehicleMotionData.Mileage.Value, actualVehicle.Mileage);
            Assert.Equal(vehicle.VehicleMotionData.LicensePlate.Value, actualVehicle.LicensePlate);
        }

        [Fact]
        public void should_save_a_vehicle()
        {
            VehicleRootEntity expectedVehicle = CreateVehicle();
            VehicleResource actualVehicle = CreateVehicle(expectedVehicle);

            Assert.Equal(expectedVehicle.Vin.Value, actualVehicle.Vin);
            Assert.Equal(expectedVehicle.VehicleMasterData.MileageUnit.Value.ToString(), actualVehicle.MileageUnit);
            Assert.Equal(expectedVehicle.VehicleMasterData.SerialNumber.Value, actualVehicle.SerialNumber);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel.ModelType, actualVehicle.VehicleModelType);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel.ModelDescription, actualVehicle.VehicleModelDescription);
            Assert.Equal(expectedVehicle.VehicleMotionData.Mileage.Value, actualVehicle.Mileage);
            Assert.Equal(expectedVehicle.VehicleMotionData.LicensePlate.Value, actualVehicle.LicensePlate);
        }

        [Fact]
        public void should_update_a_vehicle()
        {
            VehicleRootEntity expectedVehicle = CreateVehicle();
            VehicleResource actualVehicle = UpdateVehicle(expectedVehicle);

            Assert.Equal(expectedVehicle.Vin.Value, actualVehicle.Vin);
            Assert.Equal(expectedVehicle.VehicleMasterData.MileageUnit.Value.ToString(), actualVehicle.MileageUnit);
            Assert.Equal(expectedVehicle.VehicleMasterData.SerialNumber.Value, actualVehicle.SerialNumber);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel.ModelType, actualVehicle.VehicleModelType);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel.ModelDescription, actualVehicle.VehicleModelDescription);
            Assert.Equal(expectedVehicle.VehicleMotionData.Mileage.Value, actualVehicle.Mileage);
            Assert.Equal(expectedVehicle.VehicleMotionData.LicensePlate.Value, actualVehicle.LicensePlate);
        }

        private VehicleResource CreateVehicle(VehicleRootEntity vehicleToCreate)
        {
            var vehicleQueryMock = new Mock<VehicleQuery>();
            var vehicleCommandMock = new Mock<VehicleCommand>();
            vehicleCommandMock.Setup(c => c.Create(vehicleToCreate)).Returns(vehicleToCreate);

            return new VehicleController(vehicleQueryMock.Object, vehicleCommandMock.Object,
                new VehicleToVehicleResourceMapper()).CreateVehicle(CreateVehicleResource());
        }

        private VehicleResource UpdateVehicle(VehicleRootEntity vehicleToSave)
        {
            var vehicleQueryMock = new Mock<VehicleQuery>();
            var vehicleCommandMock = new Mock<VehicleCommand>();
            vehicleCommandMock.Setup(c => c.Update(vehicleToSave.Vin, vehicleToSave.VehicleMotionData)).Returns(vehicleToSave);

            return new VehicleController(vehicleQueryMock.Object, vehicleCommandMock.Object,
                new VehicleToVehicleResourceMapper()).UpdateVehicle(vehicleToSave.Vin.Value, CreateVehicleMotionDataResource());
        }
    }
}
