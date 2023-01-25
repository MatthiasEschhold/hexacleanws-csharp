/*
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Test;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab2
{
    public class OutputAdapter_Task_2_3 : BaseTest
    {
        public OutputAdapter_Task_2_3() { }

        [Fact]
        public void vehicle_repository_should_return_a_valid_vehicle()
        {
            VehicleRootEntity vehicle = CreateVehicle();

            var actualVehicle = new VehicleRepository().FindVehicleByVin(new Vin("WP0ZZZ99ZTS392155"));

            Assert.Equal(vehicle, actualVehicle);
        }
    }

    protected VehicleRootEntity CreateVehicle()
    {
        return new VehicleRootEntity(new Vin("WP0ZZZ99ZTS392155"));
    }
}*/

