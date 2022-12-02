using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Domain.Service
{
    public class FahrzeugService : VehicleQuery
    {
        private readonly VehicleDbQuery fetchExternalFahrzeug;

        public FahrzeugService(VehicleDbQuery fetchExternalFahrzeug)
        {
            this.fetchExternalFahrzeug = fetchExternalFahrzeug;
        }

        public Model.VehicleRootEntity Fetch(string fahrgestellnummer)
        {
            return fetchExternalFahrzeug.Fetch(fahrgestellnummer);
        }
    }
}
