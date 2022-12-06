
using clean_architecture_mapping_demo.Source.Vehicle.Adapter.Out.Db;
using Hexacleanws.Vehicle.Test;
using Xunit;

namespace Hexacleanws.Vehicle.Test.Lab3
{
	public class DbEntity_Task_3_1 : BaseTest
	{
        [Fact]
		public void should_return_db_entity()
		{
            VehicleDbEntity dbEntity = CreateVehicleDbEntity();
            Assert.Equal(VIN, dbEntity.Vin);
		}

    }
}

