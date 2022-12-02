

using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Domain.Model
{
    public class VehicleRootEntity
    {
        public Vin vin { get; }

        public VehicleRootEntity(Vin vin)
        {
            this.vin = vin;
            if(this.vin == null)
            {
                throw new Exception("Vin should not be null");
            }
        }

    }
}
