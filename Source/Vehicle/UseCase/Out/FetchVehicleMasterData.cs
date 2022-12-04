
using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.Out
{
	public interface FetchVehicleMasterData
	{
		VehicleRootEntity Find(Vin vin);
	}
}

