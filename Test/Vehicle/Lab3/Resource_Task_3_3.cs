using System;
using Hexacleanws.Vehicle.Adapter.In.Web;
using Hexacleanws.Vehicle.Adapter.Out.Db;
using Hexacleanws.Vehicle.Test;
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

