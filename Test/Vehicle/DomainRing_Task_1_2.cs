
using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Domain.Service;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Vehicle
{
    public class DomainRing_Task_1_2 : BaseTest
    {

        [Fact]
        void should_return_a_vehicle_identified_by_vin()
        {
            VehicleRootEntity vehicle = new VehicleService().FindByVin(new Vin(VIN));
            Assert.Equal(VIN, vehicle.vin.value);
        }

    }
}

