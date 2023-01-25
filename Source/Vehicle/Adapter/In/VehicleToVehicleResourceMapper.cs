using AutoMapper;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Microsoft.OpenApi.Validations;

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
                    .ForPath(dest => dest.VehicleModelType, opt => opt.MapFrom(s => s.VehicleMasterData.VehicleModel.ModelType))
                    .ForPath(dest => dest.EquipmentList, opt => opt.MapFrom(s => CreateEquipmentResourceList(s.VehicleMasterData.EquipmentList)));

                cfg.CreateMap<VehicleResource, VehicleRootEntity>()
                    .ForCtorParam("vin", opt => opt.MapFrom(src => new Vin(src.Vin)))
                    .ForCtorParam("vehicleMotionData", opt => opt.MapFrom(src => CreateVehicleMotionData(src)))
                    .ForCtorParam("vehicleMasterData", opt => opt.MapFrom(src => CreateVehicleMasterData(src)));

            });

            Mapper = new Mapper(Config);

        }

        private List<Equipment> CreateEquipmentList(List<EquipmentResource> equipmentList)
        {
            var entityList = new List<Equipment>();
            foreach (EquipmentResource equipment in equipmentList)
            {
                entityList.Add(new Equipment(new EquipmentCode(equipment.Code), equipment.Description));
            }
            return entityList;
        }

        private List<EquipmentResource> CreateEquipmentResourceList(List<Equipment> equipmentList)
        {
            var resourceList = new List<EquipmentResource>();
            foreach(Equipment equipment in equipmentList)
            {
                var resource = new EquipmentResource();
                resource.Code = equipment.Code.Value;
                resource.Description = equipment.Description;
                resourceList.Add(new EquipmentResource());
            }
            return resourceList;
        }

        private VehicleMotionData CreateVehicleMotionData(VehicleResource resource)
        {
            return new VehicleMotionData(new LicensePlate(resource.LicensePlate), new Mileage(resource.Mileage));
        }
        private VehicleMasterData CreateVehicleMasterData(VehicleResource resource)
        {
            var mileageUnitValue = resource.MileageUnit.Equals(MileageUnitValue.KM) ? MileageUnitValue.KM: MileageUnitValue.MILES;
            return new VehicleMasterData(CreateEquipmentList(resource.EquipmentList), new VehicleModel(resource.VehicleModelName, resource.VehicleModelType),
                            new SerialNumber(resource.SerialNumber), new MileageUnit(mileageUnitValue));
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

