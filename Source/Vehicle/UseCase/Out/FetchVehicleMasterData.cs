
using clean_architecture_mapping_demo.Source.Vehicle.Domain.Model;

namespace clean_architecture_mapping_demo.Source.Vehicle.UseCase.Out
{
    public interface FetchVehicleMasterData
    {
        VehicleMasterData Fetch(Vin vin);
    }
}

