/*using Hexacleanws.Source.Vehicle.Adapter.Out;
using Hexacleanws.Source.Vehicle.Domain.Model;
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
            Assert.Equal(vehicle, CreateVehicle());
        }

        private VehicleRootEntity MapVehicleDbEntityToVehicle(VehicleDbEntity dbEntity)
        {
            return new VehicleToVehicleDbEntityMapper().MapVehicleDbEntityToVehicle(dbEntity);
        }

        private VehicleDbEntity CreateVehicleDbEntity()
        {
            VehicleDbEntity dbEntity = new VehicleDbEntity();
            dbEntity.Vin = VIN;
            return dbEntity;
        }

    }
}*/