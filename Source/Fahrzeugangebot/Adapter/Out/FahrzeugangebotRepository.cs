using Hexacleanws.Source.Fahrzeugangebot.Domain.Model;
using Hexacleanws.Source.Fahrzeugangebot.UseCase.Out;

namespace Hexacleanws.Source.Fahrzeugangebot.Adapter.Out
{
    public class FahrzeugangebotRepository : FahrzeugangebotDbQuery, FahrzeugangebotDbCommand
    {
        public FahrzeugangebotEntity Read(string angebotsnummer)
        {
            return new FahrzeugangebotEntity();
        }

        public FahrzeugangebotEntity Save(FahrzeugangebotEntity fahrzeugangebot)
        {
            return new FahrzeugangebotEntity();
        }
    }
}
