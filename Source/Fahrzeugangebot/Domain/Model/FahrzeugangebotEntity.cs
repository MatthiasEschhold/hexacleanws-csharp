using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Source.Fahrzeugangebot.Domain.Model
{
    public class FahrzeugangebotEntity
    {
        string Angebotsnummer { get; set; }
        Vehicle.Domain.Model.VehicleRootEntity Fahrzeug { get; set; }
    }
}
