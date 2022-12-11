
using Hexacleanws.Source.Garage.Order.Adapter.Out.Vehicle;
using Hexacleanws.Source.Garage.Order.Domain.Model;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Test;
using Moq;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab6
{
    public class OutputAdapter_Task_6_2 : BaseTest
    {
        void vehicle_and_vin_should_be_created_successful()
        {
            LicensePlate licensePlate = new LicensePlate(LICENSE_PLATE_TEST_VALUE);
            var findVehicleByLicensePlateMock = new Mock<FetchVehicleByLicensePlate>();
            findVehicleByLicensePlateMock.Setup(f => f.FindByLicensePlate(licensePlate)).Returns(CreateVehicle());

            VehicleData actualVehicle = new VehicleModuleClient(findVehicleByLicensePlateMock.Object, new VehicleToOriginVehicleMapper()).FetchByLicensePlate(licensePlate.Value);

            Assert.Equal(licensePlate.Value, actualVehicle.LicensePlate);
        }
    }
}
