
using Hexacleanws.Source.Vehicle.Domain.dto;
using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.UseCase.Out
{
	public interface FetchVehicleMasterData
	{
		VehicleMasterDataDomainDto Fetch(Vin vin);
	}
}

