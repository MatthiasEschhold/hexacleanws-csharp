namespace Hexacleanws.Source.Parts.Catalogue.Domain.Model
{
    public class SparePart
    {
        public String PartNumber { get; }
        public String Description { get; }

        public SparePart(string partNumber, string description)
        {
            PartNumber = partNumber;
            Description = description;
        }
    }
}
