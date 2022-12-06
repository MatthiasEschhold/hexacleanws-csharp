using clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Parts.Catalogue.Appservice
{
    public class VehicleToOriginVehicleMapper
    {
        public VehicleData MapVehicleRootEntityToVehicleData(VehicleRootEntity entity)
        {
            return new VehicleData(entity.Vin.Value, entity.VehicleMasterData.VehicleModel.ModelType, entity.Has2GSupport);
        }
    }
}
