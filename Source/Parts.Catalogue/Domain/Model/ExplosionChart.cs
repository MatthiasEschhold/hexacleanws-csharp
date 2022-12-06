namespace clean_architecture_mapping_demo.Source.Parts.Catalogue.Domain.Model
{
    public class ExplosionChart
    {
        public VehicleData Vehicle { get; }
        public List<SparePart> SpareParts { get; }

        public PartsCategoryCode PartsCategoryCode { get; }

        public ExplosionChart(VehicleData vehicle, List<SparePart> spareParts, PartsCategoryCode partsCategoryCode)
        {
            Vehicle = vehicle;
            SpareParts = spareParts;
            PartsCategoryCode = partsCategoryCode;
        }

        internal static void DoSomeIdependentBusinessLogic()
        {
            throw new NotImplementedException();
        }
    }
}
