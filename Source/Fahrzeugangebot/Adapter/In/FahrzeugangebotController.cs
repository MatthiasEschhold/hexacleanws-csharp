using Hexacleanws.Source.Fahrzeugangebot.Domain.Model;
using Hexacleanws.Source.Fahrzeugangebot.UseCase.In;
using Microsoft.AspNetCore.Mvc;

namespace Hexacleanws.Source.Fahrzeugangebot.Adapter.In
{
    public class FahrzeugangebotController : ControllerBase
    {
        private readonly CreateFahrzeugangebot createFahrzeugangebot;

        public FahrzeugangebotController(CreateFahrzeugangebot createFahrzeugangebot)
        {
            this.createFahrzeugangebot = createFahrzeugangebot;
        }

        [HttpPost(Name = "PostFahrzeugangebot")]
        public FahrzeugangebotResource CreateFahrzeugangebot(FahrzeugangebotResource fahrzeugangebotResource)
        {
            FahrzeugangebotEntity entity = createFahrzeugangebot.Create(new FahrzeugangebotEntity());
            return new FahrzeugangebotResource();
        }
    }
}
