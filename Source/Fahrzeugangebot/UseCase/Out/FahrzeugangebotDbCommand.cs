using Hexacleanws.Source.Fahrzeugangebot.Domain.Model;

namespace Hexacleanws.Source.Fahrzeugangebot.UseCase.Out
{
    public interface FahrzeugangebotDbCommand
    {
        FahrzeugangebotEntity Save(FahrzeugangebotEntity fahrzeugangebot);
    }
}
