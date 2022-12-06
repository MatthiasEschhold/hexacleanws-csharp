using AutoMapper;
using Hexacleanws.Vehicle.Domain.dto;

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleMasterDataToVehicleDataDtoMapper
    {
        private readonly MapperConfiguration Config;
        private readonly Mapper mapper;
        public VehicleMasterDataToVehicleDataDtoMapper()
        {
            Config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VehicleMasterDataDomainDto, VehicleDataDto>()
               .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(s => s.SerialNumber.Value))
               .ForMember(dest => dest.Baumuster, opt => opt.MapFrom(s => s.VehicleModel.ModelType))
               .ForMember(dest => dest.BaumusterDescription, opt => opt.MapFrom(s => s.VehicleModel.ModelDescription))
               .ForMember(dest => dest.MileageUnit, opt => opt.MapFrom(s => s.MileageUnit))
               //.ForMember(dest => dest.EquipmentList, opt => opt.MapFrom(s => s.EquipmentCodes);

            });
#
           
        }
    }
}
