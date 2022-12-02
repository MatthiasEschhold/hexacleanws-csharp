using Hexacleanws.Source.Fahrzeugangebot.Adapter.Out;
using Hexacleanws.Source.Fahrzeugangebot.Domain.Model;
using Hexacleanws.Source.Fahrzeugangebot.UseCase.In;
using Hexacleanws.Source.Fahrzeugangebot.UseCase.Out;

namespace Hexacleanws.Source.Fahrzeugangebot.Domain.Service
{
    public class FahrzeugangebotService : CreateFahrzeugangebot, ReadFahrzeugangebot
    {

        private readonly FahrzeugangebotDbQuery dbQuery;
        private readonly FahrzeugangebotDbCommand dbCommand;

        public FahrzeugangebotService(FahrzeugangebotDbQuery dbQuery, FahrzeugangebotDbCommand dbCommand)
        {
            this.dbQuery = dbQuery;
            this.dbCommand = dbCommand;
        }

        public FahrzeugangebotEntity Create(FahrzeugangebotEntity fahrzeugangebot)
        {
            return dbCommand.Save(fahrzeugangebot);
        }

        public FahrzeugangebotEntity Read(string angebotsnummer)
        {
            FahrzeugangebotDbEntity dbEntity = new FahrzeugangebotDbEntity();
            return dbQuery.Read(angebotsnummer);
        }
    }
}
