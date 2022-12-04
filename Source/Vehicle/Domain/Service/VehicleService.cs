using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.In;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Domain.Service
{
    public class FahrzeugService : VehicleQuery
    {
        private readonly VehicleDbQuery dbQuery;

        public FahrzeugService(VehicleDbQuery dbQuery)
        {
            this.dbQuery = dbQuery;
        }

        public Model.VehicleRootEntity FindByVin(Vin vin)
        {
            return dbQuery.FindVehicleByVin(vin);
        }
    }
}
