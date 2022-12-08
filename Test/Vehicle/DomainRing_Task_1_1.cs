using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Test;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle
{
    public class DomainRing_Task_1_1 : BaseTest
    {

        [Fact]
        void should_throw_a_exception_due_to_invalid_vin()
        {
            Assert.Throws<Exception>(() => new VehicleRootEntity(new Vin("hgjhgkjhkhkhjh")));
        }

        [Fact]
        void should_throw_illegal_state_exception_due_to_null_for_vin()
        {
            Assert.Throws<Exception>(() => new VehicleRootEntity(null));
        }

        [Fact]
        void vehicle_and_vin_should_be_created_successful()
        {
            Vin vin = new Vin(VIN);
            VehicleRootEntity vehicle = new VehicleRootEntity(vin);
            Assert.Equal(vehicle.vin, vin);
        }

    }
}

