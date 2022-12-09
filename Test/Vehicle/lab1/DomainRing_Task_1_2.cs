using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.Domain.Service;
using Hexacleanws.Vehicle.Test;
using Xunit;

namespace Hexacleanws.Test.Vehicle.lab
{
    public class DomainRing_Task_1_2 : BaseTest
    {

        [Fact]
        void should_return_a_vehicle_identified_by_vin()
        {
            VehicleRootEntity vehicle = new VehicleService().FindByVin(new Vin(VIN));
            Assert.Equal(VIN, vehicle.Vin.Value);
        }

    }
}

