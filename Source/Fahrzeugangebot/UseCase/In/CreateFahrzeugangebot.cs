using Hexacleanws.Source.Fahrzeugangebot.Domain.Model;

namespace Hexacleanws.Source.Fahrzeugangebot.UseCase.In
{
    public interface CreateFahrzeugangebot
    {
        FahrzeugangebotEntity Create(FahrzeugangebotEntity fahrzeugangebot);
    }
}
