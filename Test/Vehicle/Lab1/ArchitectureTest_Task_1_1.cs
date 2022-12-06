using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Xunit;

//add a using directive to ArchUnitNET.Fluent.ArchRuleDefinition to easily define ArchRules
using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;

namespace Hexacleanws.Vehicle.Test.Vehicle.Lab1
{
    
    public class ArchitectureTest_Task_1_1 : BaseArchTest
    {

        [Fact]
        public void check_vehicle_service()
        {
            IArchRule rule = Classes()
                .That()
                .HaveName(SERVICE_UNDER_TEST)
                .Should().DependOnAny(Classes()
                    .That()
                    .HaveName(ROOT_ENTITY_UNDER_TEST)
                    .And()
                    .HaveName(VALUE_OBJECT_UNDER_TEST)
                    .And()
                    .HaveFullNameContaining("System"));

            rule.Check(Architecture);
        }

    }
}
