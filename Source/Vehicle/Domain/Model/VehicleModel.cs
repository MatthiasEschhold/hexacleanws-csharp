namespace Hexacleanws.Source.Vehicle.Domain.Model

{
    public class VehicleModel
    {
        public String ModelDescription { get; }
        public String ModelType { get; }

        public VehicleModel(string modelDescription, string modelType )
        {
            ModelDescription = modelDescription;
            ModelType = modelType;
            Validate();
        }

        private void Validate()
        {
            if (ModelDescription == string.Empty || ModelType == string.Empty)
            {
                throw new Exception("Model description and / or model type are not valid");
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is VehicleModel model &&
                   ModelDescription == model.ModelDescription &&
                   ModelType == model.ModelType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ModelDescription, ModelType);
        }
    }
}
