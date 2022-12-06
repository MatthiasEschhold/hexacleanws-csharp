using clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Parts.Catalogue.UseCase.Out
{
    public interface FindExplosionChart
    {
        ExplosionChart Find(PartsCategoryCode partsCategoryId, String vehicleModel, bool has2GSupport);
    }
}
