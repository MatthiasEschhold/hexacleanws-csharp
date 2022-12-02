using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.In
{
    public interface VehicleQuery
    {
        public Domain.Model.VehicleRootEntity Fetch(string fahrgestellnummer);
    }
}
