
using Hexacleanws.Source.Parts.Catalogue.Domain.Model;

namespace Hexacleanws.Source.Parts.Catalogue.UseCase.In
{
    public interface ExplosionChartQuery
    {
        ExplosionChart Find(PartsCategoryCode partsCategoryCode, string vin);
    }
}
