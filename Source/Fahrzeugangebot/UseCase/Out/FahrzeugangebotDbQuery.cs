using Hexacleanws.Source.Fahrzeugangebot.Domain.Model;

namespace Hexacleanws.Source.Fahrzeugangebot.UseCase.Out
{
    public interface FahrzeugangebotDbQuery
    {
        FahrzeugangebotEntity Read(String angebotsnummer);
    }
}
