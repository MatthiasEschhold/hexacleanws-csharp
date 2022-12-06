﻿namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class MileageUnit
    {
        public MileageUnitValue Value { get; }
        public MileageUnit(MileageUnitValue value)
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            return obj is MileageUnit unit &&
                   Value == unit.Value;
        }
    }
}

