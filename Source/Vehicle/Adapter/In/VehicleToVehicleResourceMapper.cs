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
                    .ForMember(dest => dest.Vin, opt => opt.MapFrom(s => s.Vin.Value)); ;

                cfg.CreateMap<VehicleResource, VehicleRootEntity>()
                    .ForMember(dest => dest.Vin.Value, opt => opt.MapFrom(s => s.Vin));

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

