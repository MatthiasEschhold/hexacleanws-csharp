namespace Hexacleanws.Source.Parts.Catalogue.Domain.Model
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

        public void DoSomeIdependentBusinessLogic()
        {
            
        }
    }
}
