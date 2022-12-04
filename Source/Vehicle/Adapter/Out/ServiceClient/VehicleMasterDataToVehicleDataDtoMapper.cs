using AutoMapper;
using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataToVehicleDataDtoKapper : Profile
    {
        public VehicleMasterDataToVehicleDataDtoKapper()
        {
            CreateMap<VehicleRootEntity, VehicleDataDto>().ReverseMap();
            CreateMap<VehicleRootEntity, VehicleDataDto>()
                .ForMember(dest => dest.vinOrFin, opt => opt.MapFrom(s => s.vin));
                //.ForMember(dest => dest.ModelType, opt => opt.MapFrom(s => s.Fahrzeugmodell))
                //.ForMember(dest => dest.Mileage, opt => opt.MapFrom(s => s.Kilometerstand));

        }
    }
}
