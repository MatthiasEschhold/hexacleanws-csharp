
using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.Out
{
	public interface FetchVehicleMasterData
	{
		VehicleMasterData Fetch(Vin vin);
	}
}

