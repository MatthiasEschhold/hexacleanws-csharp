using Hexacleanws.Source.Fahrzeugbewertung.Domain.Model;

namespace Hexacleanws.Source.Fahrzeugbewertung.UseCase.In
{
    public interface CreateFahrzeugbewertung
    {
        FahrzeugbewertungEntity Create(FahrzeugbewertungEntity fahrzeugbewertung);
    }
}
