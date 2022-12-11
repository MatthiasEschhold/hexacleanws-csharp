/*
using Hexacleanws.Source.Vehicle.Adapter.Out.db;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Test;

using Moq;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab4
{
    public class OutputAdapter_Task_4_4 : BaseTest
    {
        public OutputAdapter_Task_4_4() { }

        [Fact]
        public void vehicle_repository_should_return_a_valid_vehicle()
        {
            VehicleRootEntity vehicle = CreateVehicleWithoutMasterData();

            var actualVehicle = new VehicleRepository(new VehicleToVehicleDbEntityMapper()).FindVehicleByVin(new Vin(VIN));

            Assert.Equal(vehicle.Vin, actualVehicle.Vin);
            Assert.Equal(vehicle.VehicleMotionData.LicensePlate, actualVehicle.VehicleMotionData.LicensePlate);
            Assert.Equal(vehicle.VehicleMotionData.Mileage.Value, actualVehicle.VehicleMotionData.Mileage.Value);
        }
    }
}*/

