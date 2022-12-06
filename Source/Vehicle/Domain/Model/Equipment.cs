namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
    public class Equipment
    {
        public EquipmentCode Code { get; }
        public string Description { get; }
        public Equipment(EquipmentCode code, string description)
        {
            Code = code;
            Description = description;
            Validate();
        }

        private void Validate()
        {
            if (Code == null || Description == string.Empty || Description == "")
            {
                throw new Exception("Equipment code and / or description are not valid");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Equipment equipment &&
                   EqualityComparer<EquipmentCode>.Default.Equals(Code, equipment.Code);
        }
    }
}

