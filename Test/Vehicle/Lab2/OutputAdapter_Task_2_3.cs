using Hexacleanws.Source.Vehicle.Adapter.Out;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Vehicle.Lab2
{
	public class OutputAdapter_Task_2_3 : BaseTest
	{
		public OutputAdapter_Task_2_3() {}

        [Fact]
        public void vehicle_repository_should_return_a_valid_vehicle()
        {
            VehicleRootEntity vehicle = CreateVehicle();

            var actualVehicle = new VehicleRepository().FindVehicleByVin(new Vin(VIN));

            Assert.Equal(vehicle, actualVehicle);
        }
    }
}

