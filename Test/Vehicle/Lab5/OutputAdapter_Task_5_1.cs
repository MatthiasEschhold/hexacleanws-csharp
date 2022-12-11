/*
using Hexacleanws.Source.Vehicle.Adapter.Out.db;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Test;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab5
{
    public class OutputAdapter_Task_5_1 : BaseTest
    {
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
*/