
using Hexacleanws.Vehicle.Adapter.In.Web;
using Hexacleanws.Vehicle.Domain.Model;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Lab3
{
	public class Mapper_Task_3_3 : BaseTest
	{

        [Fact]
        void should_map_vehicle_resource_to_vehicle()
        {
            VehicleResource resource = CreateVehicleResource();
            VehicleRootEntity vehicle = new VehicleToVehicleResourceMapper().MapVehicleResourceToVehicle(resource);
            VehicleRootEntity expectedVehicle = CreateVehicle();
            //Assert.Equal(vehicle.Vin, expectedVehicle.Vin);
            //Assert.Equal(vehicle.VehicleMasterData.VehicleModel, expectedVehicle.VehicleMasterData.VehicleModel);
            //Assert.Equal(vehicle.VehicleMasterData.MileageUnit.Value, expectedVehicle.VehicleMasterData.MileageUnit.Value);
            //Assert.Equal(vehicle.VehicleMasterData.SerialNumber, expectedVehicle.VehicleMasterData.SerialNumber);
            //Assert.Equal(vehicle.VehicleMotionData.LicensePlate, expectedVehicle.VehicleMotionData.LicensePlate);
            //Assert.Equal(vehicle.VehicleMotionData.Mileage, expectedVehicle.VehicleMotionData.Mileage);
        }

        [Fact]
        void should_map_vehicle_to_vehicle_resource()
        {
            VehicleRootEntity entity = CreateVehicle();
            VehicleResource vehicle = new VehicleToVehicleResourceMapper().MapVehicleToVehicleResource(entity);
            VehicleResource expectedResource = CreateVehicleResource();
            Assert.Equal(vehicle.Vin, expectedResource.Vin);
            Assert.Equal(vehicle.VehicleModelName, expectedResource.VehicleModelName);
            Assert.Equal(vehicle.VehicleModelDescription, expectedResource.VehicleModelDescription);
            Assert.Equal(vehicle.MileageUnit, expectedResource.MileageUnit);
            Assert.Equal(vehicle.SerialNumber, expectedResource.SerialNumber);
            Assert.Equal(vehicle.LicensePlate, expectedResource.LicensePlate);
            Assert.Equal(vehicle.Mileage, expectedResource.Mileage);
        }

    }
}

