﻿using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Vehicle.Adapter.Out.Db
{
    public class VehicleToVehicleDbEntityMapper
    {
        public VehicleRootEntity MapVehicleDbEntityToVehicle(VehicleDbEntity dbEntity)
        {
            VehicleRootEntity entity = new VehicleRootEntity(new Vin(dbEntity.Vin),
                new VehicleMotionData(new LicensePlate(dbEntity.LicensePlate),
                new Mileage(dbEntity.Mileage)));
            return entity;
        }
    }
}
