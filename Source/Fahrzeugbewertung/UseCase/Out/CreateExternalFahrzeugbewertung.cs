using Hexacleanws.Source.Fahrzeugbewertung.Domain.Model;

namespace Hexacleanws.Source.Fahrzeugbewertung.UseCase.Out
{
    public interface CreateExternalFahrzeugbewertung
    {
        FahrzeugbewertungEntity Create(FahrzeugbewertungEntity fahrzeugbewertung);
    }
}
