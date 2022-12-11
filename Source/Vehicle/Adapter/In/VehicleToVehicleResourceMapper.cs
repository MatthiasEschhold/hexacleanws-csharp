using AutoMapper;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.Adapter.In.Web;

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
                cfg.CreateMap<VehicleMotionData, VehicleMotionDataResource>()
                   .ForMember(dest => dest.LicensePlate, opt => opt.MapFrom(s => s.LicensePlate))
                   .ForMember(dest => dest.Mileage, opt => opt.MapFrom(s => s.Mileage)); ;

                cfg.CreateMap<VehicleRootEntity, VehicleResource>()
                    .ForMember(dest => dest.Vin, opt => opt.MapFrom(s => s.Vin.Value))
                    .ForMember(dest => dest.LicensePlate, opt => opt.MapFrom(s => s.VehicleMotionData.LicensePlate.Value))
                    .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(s => s.VehicleMasterData.SerialNumber.Value))
                    .ForMember(dest => dest.MileageUnit, opt => opt.MapFrom(s => s.VehicleMasterData.MileageUnit.Value.ToString()))
                    .ForMember(dest => dest.Mileage, opt => opt.MapFrom(s => s.VehicleMotionData.Mileage.Value))
                    .ForMember(dest => dest.VehicleModelDescription, opt => opt.MapFrom(s => s.VehicleMasterData.VehicleModel.ModelDescription))
                    .ForMember(dest => dest.VehicleModelType, opt => opt.MapFrom(s => s.VehicleMasterData.VehicleModel.ModelType)); ;
                //equipment...
                cfg.CreateMap<VehicleResource, VehicleRootEntity>()
                    .ForMember(dest => dest.Vin.Value, opt => opt.MapFrom(s => s.Vin));
                //.ForMember(dest => dest.VehicleMotionData, opt => opt.MapFrom(s => s.VehicleMotionData.Mileage.Value))
                //.ForMember(dest => dest.VehicleMasterData.VehicleModel, opt => opt.MapFrom(s => s.VehicleMasterData.VehicleModel.ModelDescription))

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

        public VehicleMotionData MapVehicleMotionDataResourceToVehicleMotionData(VehicleMotionDataResource resource)
        {
            return Mapper.Map<VehicleMotionDataResource, VehicleMotionData>(resource);
        }

    }
}

