
using Hexacleanws.Source.Parts.Catalogue.Domain.Model;
using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Parts.Catalogue.Appservice
{
    public class VehicleToOriginVehicleMapper
    {
        public VehicleData MapVehicleRootEntityToVehicleData(VehicleRootEntity entity)
        {
            return new VehicleData(entity.Vin.Value, entity.VehicleMasterData.VehicleModel.ModelDescription, entity.Has2GSupport);
        }
    }
}
