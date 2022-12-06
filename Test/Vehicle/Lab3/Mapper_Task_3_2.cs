
using Hexacleanws.Vehicle.Adapter.Out.Db;
using Hexacleanws.Vehicle.Domain.Model;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Lab3
{
	public class Mapper_Task_3_2 : BaseTest
	{
        [Fact]
        void vehicle_and_vin_should_be_created_successful()
        {
            VehicleDbEntity dbEntity = CreateVehicleDbEntity();
            VehicleRootEntity vehicle = MapVehicleDbEntityToVehicle(dbEntity);
            VehicleRootEntity expectedVehicle = CreateVehicle();
            Assert.Equal(vehicle.Vin, expectedVehicle.Vin);
            Assert.Equal(vehicle.VehicleMotionData.LicensePlate, expectedVehicle.VehicleMotionData.LicensePlate);
            Assert.Equal(vehicle.VehicleMotionData.Mileage, expectedVehicle.VehicleMotionData.Mileage);
        }

        private VehicleRootEntity MapVehicleDbEntityToVehicle(VehicleDbEntity dbEntity)
        {
            return new VehicleToVehicleDbEntityMapper().MapVehicleDbEntityToVehicle(dbEntity);
        }

    }
}

