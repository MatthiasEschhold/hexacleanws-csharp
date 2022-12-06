using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Domain.Service;
using Hexacleanws.Vehicle.Test;
using Hexacleanws.Vehicle.UseCase.Out;
using Moq;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab5
{
    public class DomainRing_Task_5_1 : BaseTest
    {
        [Fact]
        public void vehicle_service_should_return_a_valid_vehicle()
        {
            Vin vin = new Vin(VIN);
            VehicleRootEntity expectedVehicle = CreateVehicle();

            var vehicleDbQueryMock = new Mock<VehicleDbQuery>();

            vehicleDbQueryMock.Setup(vq => vq.FindVehicleByVin(new Vin(VIN))).Returns(expectedVehicle);

            var fetchVehicleMasterDataMock = new Mock<FetchVehicleMasterData>();

            fetchVehicleMasterDataMock.Setup(vq => vq.Fetch(new Vin(VIN))).Returns(CreateVehicleMasterDataDto());

            VehicleRootEntity actualVehicle = new VehicleQueryService(vehicleDbQueryMock.Object,
                fetchVehicleMasterDataMock.Object).FindByVin(vin);

            Assert.Equal(expectedVehicle.Vin, actualVehicle.Vin);
            //Assert.Equal(vehicle.VehicleMasterData.MileageUnit.Value.ToString, actualVehicle.MileageUnit);
            Assert.Equal(expectedVehicle.VehicleMasterData.SerialNumber, actualVehicle.VehicleMasterData.SerialNumber);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel, actualVehicle.VehicleMasterData.VehicleModel);
            Assert.Equal(expectedVehicle.VehicleMotionData.Mileage, actualVehicle.VehicleMotionData.Mileage);
            Assert.Equal(expectedVehicle.VehicleMotionData.LicensePlate, actualVehicle.VehicleMotionData.LicensePlate);
        }
    }
}
