using AutoMapper;
using clean_architecture_mapping_demo.Source.Parts.Catalogue.Appservice;
using clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Model;
using clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Service;
using clean_architecture_mapping_demo.Source.Parts.Catalogue.UseCase.Out;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Test;
using Moq;
using Xunit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab6
{
    public class ApplicationService_Task_6_3 : BaseTest
    {
        [Fact]
        void the_vehicle_supports_not_2G()
        {
            var findExplosionChart = new Mock<FindExplosionChart>();
            var vehicleQuery = new Mock<VehicleQuery>();


            VehicleRootEntity vehicle = CreateVehicle();
            VehicleData expectedVehicle = new VehicleData(VIN, VEHICLE_MODEL_TYPE_TEST_VALUE, false);

            findExplosionChart.Setup(f => f.Find(new PartsCategoryCode("123"), VEHICLE_MODEL_TYPE_TEST_VALUE, false)).Returns(new ExplosionChart(expectedVehicle, null, null));

            ExplosionChartApplicationService appService = new ExplosionChartApplicationService(findExplosionChart.Object, vehicleQuery.Object,
            new VehicleToOriginVehicleMapper(), new ExplosionChartDomainService());

            ExplosionChart explosionChart = appService.Find(new PartsCategoryCode("123"), VIN);

            Assert.Equal(VIN, explosionChart.Vehicle.Vin);
            Assert.Equal(VEHICLE_MODEL_TYPE_TEST_VALUE, explosionChart.Vehicle.VehicleModelType);
            Assert.False(explosionChart.Vehicle.Has2GSupport);
        }
    }
}
