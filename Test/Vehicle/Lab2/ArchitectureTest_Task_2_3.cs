using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Xunit;

//add a using directive to ArchUnitNET.Fluent.ArchRuleDefinition to easily define ArchRules
using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab2
{
    public class ArchitectureTest_Task_2_3 : BaseArchTest
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

