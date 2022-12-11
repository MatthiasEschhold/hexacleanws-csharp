
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
            IArchRule rule = Classes()
                .That()
                .HaveName(SERVICE_UNDER_TEST)
                .Should()
                .OnlyDependOn(Classes()
                    .That()
                    .HaveName(ROOT_ENTITY_UNDER_TEST)
                    .Or()
                    .HaveName(VALUE_OBJECT_UNDER_TEST)
                    .Or()
                    .HaveName(USECASE_IN_QUERY_UNDER_TEST)
                    .Or()
                    .HaveName(USECASE_OUT_QUERY_UNDER_TEST)
                    .Or()
                    .HaveName(SERVICE_UNDER_TEST)
                 );

            rule.Check(Architecture);
        }
    }
}

