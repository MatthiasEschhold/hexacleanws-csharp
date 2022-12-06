using System;
using clean_architecture_mapping_demo.Source.Vehicle.Adapter.Out.Db;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab3
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

