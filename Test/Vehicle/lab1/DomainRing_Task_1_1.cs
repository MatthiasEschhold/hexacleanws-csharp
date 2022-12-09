using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Test;
using Xunit;

namespace Hexacleanws.Test.Vehicle.lab
{
    public class DomainRing_Task_1_1 : BaseTest
    {

        [Fact]
        void should_throw_a_exception_due_to_invalid_vin()
        {
            Assert.Throws<Exception>(() => new VehicleRootEntity(new Vin("hgjhgkjhkhkhjh")));
        }

        [Fact]
        void should_throw_a_exception_due_to_null_for_vin()
        {
            Assert.Throws<ArgumentNullException>(() => new VehicleRootEntity(null));
        }

        [Fact]
        void vehicle_and_vin_should_be_created_successfully()
        {
            Vin vin = new Vin(VIN);
            VehicleRootEntity vehicle = new VehicleRootEntity(vin);
            Assert.Equal(vehicle.Vin, vin);
        }

    }
}

