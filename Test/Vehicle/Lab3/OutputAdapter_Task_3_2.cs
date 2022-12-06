using System;
using clean_architecture_mapping_demo.Source.Vehicle.Adapter.Out.Db;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Adapter.Out.Db;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab3
{
    public class OutputAdapter_Tsk_3_2 : BaseTest
    {
        [Fact]
        void vehicle_and_vin_should_be_created_successful()
        {
            VehicleRootEntity vehicle = FindVehicleByVin();
            Assert.Equal(vehicle, CreateVehicle());
        }

        private VehicleRootEntity FindVehicleByVin()
        {
            return CreateVehicleRepository().FindVehicleByVin(new Vin(VIN));
        }

        private VehicleQueryRepository CreateVehicleRepository()
        {
            return new VehicleQueryRepository(new VehicleToVehicleDbEntityMapper());
        }
    }
}

