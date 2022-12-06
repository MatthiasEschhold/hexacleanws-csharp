﻿namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class VehicleMotionData
    {
        public LicensePlate LicensePlate { get; }
        public Mileage Mileage { get; }
        public VehicleMotionData(LicensePlate licensePlate, Mileage mileage)
        {
            LicensePlate = licensePlate;
            Mileage = mileage;
            Validate();
        }

        private void Validate()
        {
            if (Mileage == null || LicensePlate == null)
            {
                throw new Exception("Mileage and / or License plate are not valid");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is VehicleMotionData data &&
                   EqualityComparer<LicensePlate>.Default.Equals(LicensePlate, data.LicensePlate);
        }
    }
}

