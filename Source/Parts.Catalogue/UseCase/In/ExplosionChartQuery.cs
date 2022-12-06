using clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Parts.Catalogue.UseCase.In
{
    public interface ExplosionChartQuery
    {
        ExplosionChart Find(PartsCategoryCode partsCategoryCode, string vin);
    }
}
