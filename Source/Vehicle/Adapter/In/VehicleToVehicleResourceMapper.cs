using AutoMapper;
using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Vehicle.Adapter.In.Web
{
	public class VehicleToVehicleResourceMapper : Profile
	{
		public VehicleToVehicleResourceMapper()
		{
            CreateMap<VehicleRootEntity, VehicleResource>()
                .ReverseMap();

            CreateMap<VehicleRootEntity, VehicleResource>()
                .ForMember(dest => dest.Vin, opt => opt.MapFrom(s => s.Vin.Value))
                .ForMember(dest => dest.SerialNumber, opt => opt.MapFrom(s => s.VehicleMasterData.SerialNumber.Value))
                .ForMember(dest => dest.MileageUnit, opt => opt.MapFrom(s => s.VehicleMasterData.MileageUnit.Value))
                .ForMember(dest => dest.VehicleModelDescription, opt => opt.MapFrom(s => s.VehicleMasterData.VehicleModel.ModelDescription))
                .ForMember(dest => dest.VehicleModelName, opt => opt.MapFrom(s => s.VehicleMasterData.VehicleModel.ModelType));
                //equipment...

        }
    }
}

