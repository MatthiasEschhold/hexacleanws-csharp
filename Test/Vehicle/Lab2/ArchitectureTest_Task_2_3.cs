
using ArchUnitNET.Fluent;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;

namespace Hexacleanws.Vehicle.Test.Vehicle.Lab2
{
	public class ArchitectureTest_Task_2_3 : BaseTest
	{

        [Fact]
        public void check_vehicle_service()
        {
            IArchRule rule = Classes().That().HaveName("VehicleService")
                    .Should().DependOnAny(Classes().That()
                    .HaveName("VehicleRootEntity").And()
                    .HaveName("Vin").And()
                    .HaveFullNameContaining("System"));

            rule.Check(Architecture);
        }
    }
}

