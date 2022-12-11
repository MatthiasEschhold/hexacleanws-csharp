
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.Domain.Service;
using Hexacleanws.Source.Vehicle.UseCase.Out;
using Hexacleanws.Vehicle.Test;
using Hexacleanws.Vehicle.UseCase.Out;
using Moq;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab6
{
    public class DomainRing_Task_6_1 : BaseTest
    {
        [Fact]
        public void vehicle_service_should_return_a_valid_vehicle()
        {
            LicensePlate licensePlate = new LicensePlate(LICENSE_PLATE_TEST_VALUE);
            VehicleRootEntity expectedVehicle = CreateVehicle();
            var vehicleDbQueryMock = new Mock<VehicleDbQuery>();
            vehicleDbQueryMock.Setup(q => q.FindByLicensePlate(licensePlate)).Returns(expectedVehicle);

            var fetchVehicleMasterData = new Mock<FetchVehicleMasterData>();

            VehicleRootEntity actualVehicle = new VehicleQueryService(vehicleDbQueryMock.Object, fetchVehicleMasterData.Object)
                .FindByLicensePlate(licensePlate);

            Assert.Equal(expectedVehicle.Vin, actualVehicle.Vin);
            //Assert.Equal(vehicle.VehicleMasterData.MileageUnit.Value.ToString, actualVehicle.MileageUnit);
            Assert.Equal(expectedVehicle.VehicleMasterData.SerialNumber, actualVehicle.VehicleMasterData.SerialNumber);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel, actualVehicle.VehicleMasterData.VehicleModel);
            Assert.Equal(expectedVehicle.VehicleMotionData.Mileage, actualVehicle.VehicleMotionData.Mileage);
            Assert.Equal(expectedVehicle.VehicleMotionData.LicensePlate, actualVehicle.VehicleMotionData.LicensePlate);
        }
    }
}
