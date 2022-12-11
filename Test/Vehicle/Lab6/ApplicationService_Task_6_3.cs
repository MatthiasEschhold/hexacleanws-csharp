using AutoMapper;
using Hexacleanws.Source.Garage.Order.Domain.Model;
using Hexacleanws.Source.Parts.Catalogue.Appservice;
using Hexacleanws.Source.Parts.Catalogue.Domain.Model;
using Hexacleanws.Source.Parts.Catalogue.Domain.Service;
using Hexacleanws.Source.Parts.Catalogue.UseCase.Out;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.Test;
using Moq;
using Xunit;

namespace Hexacleanws.Test.Vehicle.Lab6
{
    public class ApplicationService_Task_6_3 : BaseTest
    {
        [Fact]
        void the_vehicle_supports_not_2G()
        {
            var findExplosionChart = new Mock<FindExplosionChart>();
            var vehicleQuery = new Mock<VehicleQuery>();


            VehicleRootEntity vehicle = CreateVehicle();
            Source.Parts.Catalogue.Domain.Model.VehicleData expectedVehicle = new Source.Parts.Catalogue.Domain.Model.VehicleData(VIN, VEHICLE_MODEL_TYPE_TEST_VALUE, false);

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
