
using Hexacleanws.Vehicle.Domain.dto;
using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.Out
{
	public interface FetchVehicleMasterData
	{
		VehicleMasterDataDomainDto Fetch(Vin vin);
	}
}

