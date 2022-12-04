
using System.Text.RegularExpressions;

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
