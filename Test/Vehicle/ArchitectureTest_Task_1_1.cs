using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Xunit;

//add a using directive to ArchUnitNET.Fluent.ArchRuleDefinition to easily define ArchRules
using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;

namespace Hexacleanws.Vehicle.Test.Vehicle
{
    
    public class ArchitectureTest_Task_1_1
    {

        const string VEHICLE_MODULE = "Hexacleanws.Vehicle";

        private static readonly Architecture Architecture =
            new ArchLoader().LoadNamespacesWithinAssembly(typeof(Program).Assembly, 
                new string[]{ VEHICLE_MODULE }).Build();

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
