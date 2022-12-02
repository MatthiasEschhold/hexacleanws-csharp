using Hexacleanws.Source.Fahrzeugangebot.Domain.Model;

namespace Hexacleanws.Source.Fahrzeugbewertung.Domain.Model
{
    public class FahrzeugbewertungEntity
    {
        string Bewertungsnummer { get; set; }   
        FahrzeugangebotEntity fahrzeugangebot { get; set; }
    }
}
