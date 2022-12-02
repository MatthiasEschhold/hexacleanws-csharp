using AutoMapper;
using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class FahrzeugDtoMappingProfile : Profile
    {
        public FahrzeugDtoMappingProfile()
        {
            CreateMap<VehicleRootEntity, VehicleDto>().ReverseMap();
            CreateMap<VehicleRootEntity, VehicleDto>()
                .ForMember(dest => dest.Vin, opt => opt.MapFrom(s => s.Fahrgestellnummer))
                .ForMember(dest => dest.ModelType, opt => opt.MapFrom(s => s.Fahrzeugmodell))
                .ForMember(dest => dest.Mileage, opt => opt.MapFrom(s => s.Kilometerstand));

        }
    }
}
