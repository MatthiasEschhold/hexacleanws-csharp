using AutoMapper;
using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.Adapter.In.Web
{
    public class VehicleToVehicleResourceMapper
    {
        private MapperConfiguration Config;
        private Mapper Mapper;
        public VehicleToVehicleResourceMapper()
        {
            Config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<VehicleRootEntity, VehicleResource>()
                    .ForPath(dest => dest.Vin, opt => opt.MapFrom(s => s.Vin.Value))
                    .ForPath(dest => dest.LicensePlate, opt => opt.MapFrom(s => s.VehicleMotionData.LicensePlate.Value))
                    .ForPath(dest => dest.SerialNumber, opt => opt.MapFrom(s => s.VehicleMasterData.SerialNumber.Value))
                    .ForPath(dest => dest.MileageUnit, opt => opt.MapFrom(s => s.VehicleMasterData.MileageUnit.Value.ToString()))
                    .ForPath(dest => dest.Mileage, opt => opt.MapFrom(s => s.VehicleMotionData.Mileage.Value))
                    .ForPath(dest => dest.VehicleModelName, opt => opt.MapFrom(s => s.VehicleMasterData.VehicleModel.ModelDescription))
                    .ForPath(dest => dest.VehicleModelType, opt => opt.MapFrom(s => s.VehicleMasterData.VehicleModel.ModelType)); ;
                //equipment...
                cfg.CreateMap<VehicleResource, VehicleRootEntity>()
                    .ForPath(dest => dest.Vin.Value, opt => opt.MapFrom(s => s.Vin))
                    .ForPath(dest => dest.VehicleMotionData.Mileage, opt => opt.MapFrom(s => s.Mileage))
                    .ForPath(dest => dest.VehicleMasterData.VehicleModel.ModelDescription, opt => opt.MapFrom(s => s.VehicleModelName));

            });

            Mapper = new Mapper(Config);

        }

        public VehicleResource MapVehicleToVehicleResource(VehicleRootEntity entity)
        {
            return Mapper.Map<VehicleRootEntity, VehicleResource>(entity);
        }

        public VehicleRootEntity MapVehicleResourceToVehicle(VehicleResource resource)
        {
            return Mapper.Map<VehicleResource, VehicleRootEntity>(resource);
        }

    }
}

