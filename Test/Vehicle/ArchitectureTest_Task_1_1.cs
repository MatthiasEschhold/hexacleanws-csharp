using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;
using Hexacleanws.Vehicle.Test;

namespace Hexacleanws.Test.Vehicle
{
    
    public class ArchitectureTest_Task_1_1 : BaseTest
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
                 );

            rule.Check(Architecture);
        }

    }
}
