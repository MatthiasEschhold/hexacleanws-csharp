using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Xunit;

//add a using directive to ArchUnitNET.Fluent.ArchRuleDefinition to easily define ArchRules
using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;

namespace Hexacleanws.Test.CleanArchitecture.Structure
{
    public class CleanArchitectureRootEntityModularizationCheck
    {

        private static readonly Architecture Architecture =
            new ArchLoader().LoadNamespacesWithinAssembly(typeof(Program).Assembly, 
                new string[]{ "CleanArchitectureDemo.Fahrzeug", 
                    "CleanArchitectureDemo.Source.Fahrzeugangebot", 
                    "CleanArchitectureDemo.Source.Fahrzeugbewertung" }).Build();

        private static readonly IObjectProvider<IType> FahrzeugModule =
            Types().That().ResideInNamespace("CleanArchitectureDemo.Fahrzeug", true).As("Fahrzeug");

        private static readonly IObjectProvider<IType> FahrzeugangebotModule =
         Types().That().ResideInNamespace("CleanArchitectureDemo.Source.Fahrzeugangebot", true).As("Fahrzeugangebot");

        private static readonly IObjectProvider<IType> FahrzeugbewertungModule =
         Types().That().ResideInNamespace("CleanArchitectureDemo.Source.Fahrzeugbewertung", true).As("Fahrzeugbewertung");


        [Fact]
        public void module_fahrzeugangebot_should_not_use_other_module()
        {
            IArchRule rule = Types().That().Are(FahrzeugangebotModule)
                    .Should().NotDependOnAny(Types().That().Are(FahrzeugbewertungModule))
                    .AndShould().NotDependOnAny(Types().That().Are(FahrzeugModule));
            rule.Check(Architecture);
        }

        [Fact]
        public void module_fahrzeug_should_not_use_other_module()
        {
            IArchRule rule = Types().That().Are(FahrzeugModule)
                    .Should().NotDependOnAny(Types().That().Are(FahrzeugbewertungModule))
                    .AndShould().NotDependOnAny(Types().That().Are(FahrzeugangebotModule));
            rule.Check(Architecture);
        }

        [Fact]
        public void module_fahrzeugbewertung_should_not_use_other_module()
        {
            IArchRule rule = Types().That().Are(FahrzeugbewertungModule)
                    .Should().NotDependOnAny(Types().That().Are(FahrzeugModule))
                    .AndShould().NotDependOnAny(Types().That().Are(FahrzeugangebotModule));
            rule.Check(Architecture);
        }

    }
}
