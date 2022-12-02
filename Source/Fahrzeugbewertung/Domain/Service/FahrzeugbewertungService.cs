using Hexacleanws.Source.Fahrzeugbewertung.Domain.Model;
using Hexacleanws.Source.Fahrzeugbewertung.UseCase.In;
using Hexacleanws.Source.Fahrzeugbewertung.UseCase.Out;

namespace Hexacleanws.Source.Fahrzeugbewertung.Domain.Service
{
    public class FahrzeugbewertungService : CreateFahrzeugbewertung
    {
        private readonly CreateExternalFahrzeugbewertung createExternalFahrzeugbewertung;


        public FahrzeugbewertungService(CreateExternalFahrzeugbewertung createExternalFahrzeugbewertung) 
        {
            this.createExternalFahrzeugbewertung = createExternalFahrzeugbewertung;       
        }

        public FahrzeugbewertungEntity Create(FahrzeugbewertungEntity fahrzeugbewertung)
        {
            return createExternalFahrzeugbewertung.Create(fahrzeugbewertung);
        }
    }
}
