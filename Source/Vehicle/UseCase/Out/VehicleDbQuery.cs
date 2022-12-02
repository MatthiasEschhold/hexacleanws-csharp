using Hexacleanws.Vehicle.Domain.Model;


namespace Hexacleanws.Vehicle.UseCase.Out
{
    public interface VehicleDbQuery
    {
        Domain.Model.VehicleRootEntity Fetch(string fahrgestellnummer);
    }
}
