using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Domain.Service;
using Hexacleanws.Vehicle.Test;
using Hexacleanws.Vehicle.UseCase.Out;
using Moq;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab5
{
    public class DomainService_Task_5_2 : BaseTest
    {
        [Fact]
        public void should_create_a_vehicle()
        {
            VehicleRootEntity expectedVehicle = CreateVehicle();
            VehicleRootEntity actualVehicle = CreateVehicle(expectedVehicle);


            Assert.Equal(expectedVehicle.Vin, actualVehicle.Vin);
            //Assert.Equal(vehicle.VehicleMasterData.MileageUnit.Value.ToString, actualVehicle.MileageUnit);
            Assert.Equal(expectedVehicle.VehicleMasterData.SerialNumber, actualVehicle.VehicleMasterData.SerialNumber);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel, actualVehicle.VehicleMasterData.VehicleModel);
            Assert.Equal(expectedVehicle.VehicleMotionData.Mileage, actualVehicle.VehicleMotionData.Mileage);
            Assert.Equal(expectedVehicle.VehicleMotionData.LicensePlate, actualVehicle.VehicleMotionData.LicensePlate);
        }
    void should_update_a_vehicle()
        { 
            VehicleRootEntity expectedVehicle = CreateVehicle();
            VehicleRootEntity actualVehicle = UpdateVehicle(expectedVehicle);

            Assert.Equal(expectedVehicle.Vin, actualVehicle.Vin);
            //Assert.Equal(vehicle.VehicleMasterData.MileageUnit.Value.ToString, actualVehicle.MileageUnit);
            Assert.Equal(expectedVehicle.VehicleMasterData.SerialNumber, actualVehicle.VehicleMasterData.SerialNumber);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel, actualVehicle.VehicleMasterData.VehicleModel);
            Assert.Equal(expectedVehicle.VehicleMotionData.Mileage, actualVehicle.VehicleMotionData.Mileage);
            Assert.Equal(expectedVehicle.VehicleMotionData.LicensePlate, actualVehicle.VehicleMotionData.LicensePlate);
        }

        private VehicleRootEntity CreateVehicle(VehicleRootEntity vehicleToCreate)
        {
            var vehicleDbCommandMock = new Mock<VehicleDbCommand>();
            vehicleDbCommandMock.Setup(c => c.Save(vehicleToCreate)).Returns(vehicleToCreate);

        return new VehicleCommandService(vehicleDbCommandMock.Object)
                .Create(vehicleToCreate);
    }

    private VehicleRootEntity UpdateVehicle(VehicleRootEntity vehicleToUpdate)
    {
            var vehicleDbCommandMock = new Mock<VehicleDbCommand>();
            vehicleDbCommandMock.Setup(c => c.Save(vehicleToUpdate)).Returns(vehicleToUpdate);

            return new VehicleCommandService(vehicleDbCommandMock.Object)
                .Update(vehicleToUpdate.Vin, vehicleToUpdate.VehicleMotionData);
}
    }
}
