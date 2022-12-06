
using clean_architecture_mapping_demo.Source.Vehicle.Adapter.In.Web;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Lab3
{
	public class Resource_Task_3_3 : BaseTest
	{
        [Fact]
		public void should_return_resource()
		{
            VehicleResource resource = CreateVehicleResource();
            Assert.Equal(VIN, resource.Vin);
		}

    }
}

