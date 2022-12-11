
using Hexacleanws.Source.Vehicle.Adapter.In;
using Hexacleanws.Source.Vehicle.Adapter.In.Web;
using Hexacleanws.Source.Vehicle.Domain.Model;
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
            Assert.Equal(vehicle, CreateVehicle());
        }

        [Fact]
        void should_map_vehicle_to_vehicle_resoirce()
        {
            VehicleRootEntity entity = CreateVehicle();
            VehicleResource vehicle = new VehicleToVehicleResourceMapper().MapVehicleToVehicleResource(entity);
            Assert.Equal(vehicle.Vin, CreateVehicleResource().Vin);
        }

    }
}

