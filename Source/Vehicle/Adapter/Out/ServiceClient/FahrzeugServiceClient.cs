using AutoMapper;

using Hexacleanws.Vehicle.Domain.Model;
using Hexacleanws.Vehicle.UseCase.Out;

namespace Hexacleanws.Vehicle.Adapter.Out.ServiceClient
{
    public class VehicleServiceClient : VehicleDbQuery
    {
        private static readonly MapperConfiguration Config = new(cfg => {
            cfg.AddProfile<FahrzeugDtoMappingProfile>();
        });

        private Mapper mapper;

        public VehicleServiceClient()
        {
            mapper = new Mapper(Config);
        }

        public Domain.Model.VehicleRootEntity Fetch(string fahrgestellnummer)
        {
            var vehicleDto = new VehicleDto(); //call from a external service
            return mapper.Map<Vehicle>(vehicleDto);
        }
    }
}
