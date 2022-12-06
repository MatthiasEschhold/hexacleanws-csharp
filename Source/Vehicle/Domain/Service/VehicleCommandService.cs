﻿using Hexacleanws.Vehicle.UseCase.Out;
using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.In;

namespace Hexacleanws.Vehicle.Domain.Service
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
