/*using Hexacleanws.Source.Vehicle.Adapter.Out;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Vehicle.Lab3
{
    public class OutputAdapter_Tsk_3_2 : BaseTest
	{
        [Fact]
        void vehicle_and_vin_should_be_created_successful()
        {
            VehicleRootEntity vehicle = FindVehicleByVin();
            Assert.Equal(vehicle, CreateVehicle());
        }

        private VehicleRootEntity FindVehicleByVin()
        {
            return CreateVehicleRepository().FindVehicleByVin(new Vin(VIN));
        }

        private VehicleRepository CreateVehicleRepository()
        {
            return new VehicleRepository(new VehicleToVehicleDbEntityMapper());
        }
    }
}*/

