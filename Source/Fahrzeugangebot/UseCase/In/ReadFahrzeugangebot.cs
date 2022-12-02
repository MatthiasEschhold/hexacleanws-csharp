using Hexacleanws.Source.Fahrzeugangebot.Domain.Model;

namespace Hexacleanws.Source.Fahrzeugangebot.UseCase.In
{
    public interface ReadFahrzeugangebot
    {
        FahrzeugangebotEntity Read(String angebotsnummer);
    }
}
