
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.Domain.Service;
using Hexacleanws.Source.Vehicle.UseCase.Out;
using Hexacleanws.Vehicle.Test;
using Hexacleanws.Vehicle.UseCase.Out;
using Moq;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab5
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

            fetchVehicleMasterDataMock.Setup(vq => vq.Fetch(new Vin(VIN))).Returns(CreateVehicleMasterData());

            VehicleRootEntity actualVehicle = new VehicleQueryService(vehicleDbQueryMock.Object,
                fetchVehicleMasterDataMock.Object).FindByVin(vin);

            Assert.Equal(expectedVehicle.Vin, actualVehicle.Vin);
            Assert.Equal(expectedVehicle.VehicleMasterData.MileageUnit.Value, actualVehicle.VehicleMasterData.MileageUnit.Value);
            Assert.Equal(expectedVehicle.VehicleMasterData.SerialNumber, actualVehicle.VehicleMasterData.SerialNumber);
            Assert.Equal(expectedVehicle.VehicleMasterData.VehicleModel, actualVehicle.VehicleMasterData.VehicleModel);
            Assert.Equal(expectedVehicle.VehicleMotionData.Mileage, actualVehicle.VehicleMotionData.Mileage);
            Assert.Equal(expectedVehicle.VehicleMotionData.LicensePlate, actualVehicle.VehicleMotionData.LicensePlate);
        }
    }
}
