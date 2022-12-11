using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Test;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab5
{
    public class DomainRing_Task_5_3 : BaseTest
    {
        [Fact]
        public void the_vehicle_supports_2G()
        {
            Vin vin = new Vin(VIN);
            VehicleRootEntity vehicle = new VehicleRootEntity(vin, CreateVehicleMotionData());
            VehicleMasterData masterData = CreateVehicleMasterData();
            vehicle.AddVehicleMasterData(masterData);
            Assert.Equal(vin, vehicle.Vin);
            Assert.True(vehicle.Has2GSupport);
        }

        [Fact]
        void the_vehicle_supports_not_2G()
        {
            Vin vin = new Vin(VIN);
            VehicleRootEntity vehicle = new VehicleRootEntity(vin, CreateVehicleMotionData());
            VehicleMasterData masterData = CreateVehicleMasterDataWithout2G();
            vehicle.AddVehicleMasterData(masterData);
            Assert.Equal(vin, vehicle.Vin);
            Assert.False(vehicle.Has2GSupport);
        }
    }
}
