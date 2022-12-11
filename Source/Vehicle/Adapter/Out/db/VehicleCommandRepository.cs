﻿
using Hexacleanws.Source.Vehicle.Adapter.Out.db;
using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Adapter.Out.Db
{
    public class VehicleCommandRepository : VehicleDbCommand
    {
        private readonly VehicleToVehicleDbEntityMapper Mapper;

        public VehicleCommandRepository(VehicleToVehicleDbEntityMapper mapper)
        {
            Mapper = mapper;
        }
        public VehicleRootEntity Save(VehicleRootEntity vehicle)
        {
            return Mapper.MapVehicleDbEntityToVehicle(TechnicalSaveWithSqlStuff(vehicle));
        }

        private VehicleDbEntity TechnicalSaveWithSqlStuff(VehicleRootEntity vehicle)
        {
           
            //make sql stuff

            VehicleDbEntity vehicleDbEntity = new VehicleDbEntity();
            vehicleDbEntity.Vin = vehicle.Vin.Value;
            vehicleDbEntity.LicensePlate = vehicle.VehicleMotionData.LicensePlate.Value;
            vehicleDbEntity.Mileage = vehicle.VehicleMotionData.Mileage.Value;
            return vehicleDbEntity;
            
        }
    }
}