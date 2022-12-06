﻿using System.Text.RegularExpressions;

namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class LicensePlate
    {
        public string Value { get; }

        public LicensePlate(string value)
        {
            Value = value;
            Validate();
        }

        private void Validate()
        {
            Regex licensePlateRegex = new Regex(@"[A-ZÖÜÄ]{1,3}-[A-ZÖÜÄ]{1,2} [1-9]{1}[0-9]{1,3}");
            if (!licensePlateRegex.IsMatch(Value))
            {
                throw new Exception("License plate is not valid.");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is LicensePlate plate &&
                   Value == plate.Value;
        }
    }
}

