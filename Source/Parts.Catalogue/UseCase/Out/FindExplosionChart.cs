
using Hexacleanws.Source.Parts.Catalogue.Domain.Model;

namespace Hexacleanws.Source.Parts.Catalogue.UseCase.Out
{
    public interface FindExplosionChart
    {
        ExplosionChart Find(PartsCategoryCode partsCategoryId, String vehicleModel, bool has2GSupport);
    }
}
