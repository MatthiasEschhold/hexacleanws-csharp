

using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.In;
using Hexacleanws.Source.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Domain.Service
{
    public class VehicleCommandService : VehicleCommand
    {
        private readonly VehicleDbCommand DbCommand;

        public VehicleCommandService(VehicleDbCommand dbCommand)
        {
            DbCommand = dbCommand;
        }

        public VehicleRootEntity Create(VehicleRootEntity vehicle)
        {
            return DbCommand.Save(vehicle);
        }

        public VehicleRootEntity Update(Vin vin, VehicleMotionData vehicleMotionData)
        {
            return DbCommand.Save(new VehicleRootEntity(vin, vehicleMotionData));
        }
    }
}
