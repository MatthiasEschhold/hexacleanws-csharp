using Hexacleanws.Source.Fahrzeugbewertung.Domain.Model;
using Hexacleanws.Source.Fahrzeugbewertung.UseCase.In;
using Microsoft.AspNetCore.Mvc;

namespace Hexacleanws.Source.Fahrzeugbewertung.Adapter.In
{
    [ApiController]
    [Route("[controller]")]
    public class FahrzeugbewertungController : Controller
    {

        private readonly CreateFahrzeugbewertung createFahrzeugbewertung;

        [HttpPost(Name = "PostFahrzeugbewertung")]
        public FahrzeugbewertungResource CreateFahrzeugbewertung(FahrzeugbewertungResource fahrzeugbewertungResource)
        {
            FahrzeugbewertungEntity entity = createFahrzeugbewertung.Create(new FahrzeugbewertungEntity());
            return new FahrzeugbewertungResource();
        }
    }
}
