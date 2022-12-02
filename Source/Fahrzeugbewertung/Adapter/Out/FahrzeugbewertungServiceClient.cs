using Hexacleanws.Source.Fahrzeugbewertung.Domain.Model;
using Hexacleanws.Source.Fahrzeugbewertung.UseCase.Out;

namespace Hexacleanws.Source.Fahrzeugbewertung.Adapter.Out
{
    public class FahrzeugbewertungServiceClient : CreateExternalFahrzeugbewertung
    {
        public FahrzeugbewertungEntity Create(FahrzeugbewertungEntity fahrzeugbewertung)
        {
            return new FahrzeugbewertungEntity();
        }
    }
}
