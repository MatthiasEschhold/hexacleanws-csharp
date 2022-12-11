
using Hexacleanws.Source.Vehicle.Adapter.Out.db;
using Hexacleanws.Source.Vehicle.Adapter.Out.Db;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Test;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab5
{
    public class OutputAdapter_Task_5_2 : BaseTest
    {
        void vehicle_and_vin_should_be_created_successful()
        {
            VehicleRootEntity expectedVehicle = CreateVehicle();
            VehicleRootEntity actualVehicle = saveVehicle(expectedVehicle);

            Assert.Equal(expectedVehicle.Vin, actualVehicle.Vin);
            Assert.Equal(expectedVehicle.VehicleMotionData.LicensePlate, actualVehicle.VehicleMotionData.LicensePlate);
            Assert.Equal(expectedVehicle.VehicleMotionData.Mileage, actualVehicle.VehicleMotionData.Mileage);
        }

        private VehicleRootEntity saveVehicle(VehicleRootEntity vehicleToSave)
        {
            return CreateVehicleRepository().Save(vehicleToSave);
        }

        private VehicleCommandRepository CreateVehicleRepository()
        {
            return new VehicleCommandRepository(new VehicleToVehicleDbEntityMapper());
        }
    }
}
