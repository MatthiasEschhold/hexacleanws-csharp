using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.In;
using clean_architecture_mapping_demo.Source.Vehicle.UseCase.Out;

namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Service
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
