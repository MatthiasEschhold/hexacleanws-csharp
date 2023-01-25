﻿using Hexacleanws.Source.Vehicle.Domain.Model;
using Hexacleanws.Source.Vehicle.UseCase.Out;

namespace Hexacleanws.Source.Vehicle.Adapter.Out
{
    public class VehicleRepository : VehicleDbQuery
    {
        public VehicleRootEntity FindVehicleByVin(Vin vin)
        {
            return new VehicleRootEntity(new Vin("WP0ZZZ99ZTS392155"));
        }

    }
}