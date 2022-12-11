﻿namespace Hexacleanws.Source.Garage.Order.Domain.Model
{
    public class VehicleData
    {
        public String LicensePlate { get; }
        public double Mileage { get; }

        public VehicleData(string licensePlate, double mileage)
        {
            LicensePlate = licensePlate;
            Mileage = mileage;
        }
    }
}
