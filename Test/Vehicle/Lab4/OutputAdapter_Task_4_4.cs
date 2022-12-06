
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Test;
using Hexacleanws.Vehicle.Adapter.Out.Db;
using Moq;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab4
{
    public class OutputAdapter_Task_4_4 : BaseTest
    {
        public OutputAdapter_Task_4_4() { }

        [Fact]
        public void vehicle_repository_should_return_a_valid_vehicle()
        {
            VehicleRootEntity vehicle = CreateVehicleWithoutMasterData();

            var actualVehicle = new VehicleQueryRepository(new VehicleToVehicleDbEntityMapper()).FindVehicleByVin(new Vin(VIN));

            Assert.Equal(vehicle.Vin, actualVehicle.Vin);
            Assert.Equal(vehicle.VehicleMotionData.LicensePlate, actualVehicle.VehicleMotionData.LicensePlate);
            Assert.Equal(vehicle.VehicleMotionData.Mileage, actualVehicle.VehicleMotionData.Mileage);
        }
    }
}

