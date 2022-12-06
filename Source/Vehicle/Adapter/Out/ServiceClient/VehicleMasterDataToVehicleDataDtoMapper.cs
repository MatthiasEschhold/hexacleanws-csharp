using AutoMapper;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataToVehicleDataDtoMapper : Profile
    {
        public VehicleMasterDataToVehicleDataDtoMapper()
        {
            CreateMap<VehicleMasterData, VehicleDataDto>().ReverseMap();
            CreateMap<VehicleMasterData, VehicleDataDto>()
                .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(s => s.SerialNumber.Value))
                .ForMember(dest => dest.Baumuster, opt => opt.MapFrom(s => s.VehicleModel.ModelType))
                .ForMember(dest => dest.BaumusterDescription, opt => opt.MapFrom(s => s.VehicleModel.ModelDescription))
                .ForMember(dest => dest.MileageUnit, opt => opt.MapFrom(s => s.MileageUnit));
            //equipment list
        }
    }
}
