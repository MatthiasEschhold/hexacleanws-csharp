
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Lab4
{
    public class DomainRing_Task_4_1 : BaseTest
    {
        private const string EQUIPMENT_CODE = "LT317";
        private const string EQUIPMENT_DESCRIPTION = "Live Traffic";

        [Fact]
        void should_throw_a_exception_due_to_invalid_vin()
        {
            Assert.Throws<Exception>(() => new VehicleRootEntity(
                new Vin("hgjhgkjhkhkhjh"), 
                CreateVehicleMotionData(), 
                CreateVehicleMasterData()));
        }

        [Fact]
        void should_throw_exception_due_to_nullable_vin()
        {
            Assert.Throws<Exception>(() => new VehicleRootEntity(null, CreateVehicleMotionData()));
        }

        [Fact]
        void should_throw_exception_due_to_nullable_vehicle_motion_data()
        {
            Assert.Throws<Exception>(() => new VehicleRootEntity(new Vin(VIN), null));
        }

        [Fact]
        void should_throw_exception_due_to_nullable_mileage()
        {
            Assert.Throws<Exception>(() => new VehicleMotionData(
                new LicensePlate(LICENSE_PLATE_TEST_VALUE), 
                null));
        }

        [Fact]
        void should_throw_exception_due_to_nullable_license_plate()
        {
            Assert.Throws<Exception>(() => new VehicleMotionData(
                null, new Mileage(MILEAGE_TEST_VALUE)));
        }

        [Fact]
        void should_throw_exception_due_to_invalid_license_plate()
        {
            Assert.Throws<Exception>(() => new VehicleMotionData(
                new LicensePlate("InvalidLicensePlate"), new Mileage(MILEAGE_TEST_VALUE)));
        }

        [Fact]
        void should_throw_exception_due_to_invalid_mileage()
        {
            Assert.Throws<Exception>(() => new VehicleMotionData(
                new LicensePlate(LICENSE_PLATE_TEST_VALUE),
                new Mileage(-0.1)));
        }


        [Fact]
        void vehicle_and_vin_should_be_created_successful()
        {
            VehicleMotionData vehicleMotionData = new VehicleMotionData(
                new LicensePlate(LICENSE_PLATE_TEST_VALUE),
                new Mileage(MILEAGE_TEST_VALUE));

            Assert.Equal(LICENSE_PLATE_TEST_VALUE, vehicleMotionData.LicensePlate.Value);
            Assert.Equal(MILEAGE_TEST_VALUE, vehicleMotionData.Mileage.Value);
        }

        [Fact]
        void vehicle_motion_data_should_be_created_successful()
        {
            Vin vin = new Vin(VIN);
            VehicleRootEntity vehicle = new VehicleRootEntity(vin, CreateVehicleMotionData());
            Assert.Equal(vehicle.Vin, vin);
        }

        [Fact]  
        void equipment_should_be_created_successful()
        {
            Equipment equipment = new Equipment(new EquipmentCode(EQUIPMENT_CODE), EQUIPMENT_DESCRIPTION);
            Assert.Equal(EQUIPMENT_CODE, equipment.Code.Value);
            Assert.Equal(EQUIPMENT_DESCRIPTION, equipment.Description);
        }

    }
}

