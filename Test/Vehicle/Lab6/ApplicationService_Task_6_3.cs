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
        public void the_vehicle_supports_not_2G()
        {
            VehicleRootEntity vehicle = CreateVehicle();
            var findExplosionChart = new Mock<FindExplosionChart>();
            var vehicleQuery = new Mock<VehicleQuery>();
            vehicleQuery.Setup(f => f.FindByVin(new Vin(VIN))).Returns(vehicle);

            VehicleData expectedVehicle = new VehicleData(VIN, vehicle.VehicleMasterData.VehicleModel.ModelType, false);

            PartsCategoryCode code = new PartsCategoryCode("123");

            findExplosionChart.Setup(f => f.Find(code, vehicle.VehicleMasterData.VehicleModel.ModelType, false)).Returns(new ExplosionChart(expectedVehicle, null, null));

            ExplosionChartApplicationService appService = new ExplosionChartApplicationService(findExplosionChart.Object, vehicleQuery.Object,
            new VehicleToOriginVehicleMapper(), new ExplosionChartDomainService());

            ExplosionChart explosionChart = appService.Find(code, vehicle.Vin.Value);

            Assert.Equal(vehicle.Vin.Value, explosionChart.Vehicle.Vin);
            Assert.Equal(vehicle.VehicleMasterData.VehicleModel.ModelType, explosionChart.Vehicle.VehicleModelType);
            Assert.Equal(vehicle.Has2GSupport, explosionChart.Vehicle.Has2GSupport);
        }
    }
}
