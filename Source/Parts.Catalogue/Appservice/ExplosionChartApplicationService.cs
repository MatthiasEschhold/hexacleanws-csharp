using clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Model;
using clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Service;
using clean_architecture_mapping_demo.Source.Parts.Catalogue.UseCase.In;
using clean_architecture_mapping_demo.Source.Parts.Catalogue.UseCase.Out;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.In;

namespace clean_architecture_mapping_demo.Source.Parts.Catalogue.Appservice
{
    public class ExplosionChartApplicationService : ExplosionChartQuery
    {
        private FindExplosionChart FindExplosionChart;
        private VehicleQuery VehicleQuery;
        private VehicleToOriginVehicleMapper VehicleToOriginVehicleMapper;
        private ExplosionChartDomainService ExplosionChartDomainService;

        public ExplosionChartApplicationService(FindExplosionChart findExplosionChart,
                                                VehicleQuery vehicleQuery,
                                                VehicleToOriginVehicleMapper vehicleToOriginVehicleMapper,
                                                ExplosionChartDomainService explosionChartDomainService)
        {
            FindExplosionChart = findExplosionChart;
            VehicleQuery = vehicleQuery;
            VehicleToOriginVehicleMapper = vehicleToOriginVehicleMapper;
            ExplosionChartDomainService = explosionChartDomainService;
        }

        public ExplosionChart Find(PartsCategoryCode partsCategoryCode, string vin)
        {
            //Add ypur code to implement the application service pattern here
            VehicleData vehicle = VehicleToOriginVehicleMapper.MapVehicleRootEntityToVehicleData(VehicleQuery.FindByVin(new Vin(vin)));
            ExplosionChart explosionChart = FindExplosionChart.Find(partsCategoryCode, vehicle.VehicleModelType, vehicle.Has2GSupport);

            //some domain logic located in the domain service respectively in the root entity
            ExplosionChartDomainService.DoSomeIdependentBusinessLogic(explosionChart);
            ExplosionChart.DoSomeIdependentBusinessLogic();

            return explosionChart;
        }
    }
}
