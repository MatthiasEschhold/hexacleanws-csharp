using System;
using clean_architecture_mapping_demo.Source.Vehicle.Adapter.In.Web;
using Hexacleanws.Vehicle.Adapter.Out.Db;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab3
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

