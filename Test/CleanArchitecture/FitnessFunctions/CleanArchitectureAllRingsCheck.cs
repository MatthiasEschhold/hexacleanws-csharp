using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Xunit;

//add a using directive to ArchUnitNET.Fluent.ArchRuleDefinition to easily define ArchRules
using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;

namespace Hexacleanws.Test.CleanArchitecture.Structure
{
    public class CleanArchitectureAllRingsCheck
    {

        private static readonly Architecture Architecture =
            new ArchLoader().LoadNamespacesWithinAssembly(typeof(Program).Assembly, 
                new string[]{ "CleanArchitectureDemo.Vehicle", 
                    "CleanArchitectureDemo.Source.Fahrzeugangebot", 
                    "CleanArchitectureDemo.Source.Fahrzeugbewertung" }).Build();

        [Fact]
        public void CleanArchitectureFitnessCheck()
        {

            IObjectProvider<IType> AdapterIn =
                Types().That().ResideInNamespace("Adapter.In", true).As("Adapter.In");

            IObjectProvider<IType> AdapterOut =
                Types().That().ResideInNamespace("Adapter.Out", true).As("Adapter.Out");

            IObjectProvider<IType> DomainModel =
                Types().That().ResideInNamespace("Domain.Model", true).As("Domain.Model");

            IObjectProvider<IType> DomainService =
                Types().That().ResideInNamespace("Domain.Service", true).As("Domain.Service");

            IObjectProvider<IType> UseCaseIn =
                Types().That().ResideInNamespace("UseCase.In", true).As("UseCase.In");

            IObjectProvider<IType> UseCaseOut =
                Types().That().ResideInNamespace("UseCase.Out", true).As("UseCase.Out");

            IArchRule domainModelArchRule =
                    Types().That().Are(DomainModel)
                    .Should().NotDependOnAny(DomainService)
                    .AndShould().NotDependOnAny(UseCaseIn)
                    .AndShould().NotDependOnAny(UseCaseOut)
                    .AndShould().NotDependOnAny(AdapterIn)
                    .AndShould().NotDependOnAny(AdapterOut);

                IArchRule domainServiceArchRule =
                   Types().That().Are(DomainService)
                    .Should().NotDependOnAny(AdapterIn)
                    .AndShould().NotDependOnAny(AdapterOut);

                IArchRule adapterInArchRule =
                   Types().That().Are(AdapterIn)
                    .Should().NotDependOnAny(DomainService)
                    .AndShould().NotDependOnAny(UseCaseOut)
                    .AndShould().NotDependOnAny(AdapterOut);

                IArchRule adapterOutArchRule =
                   Types().That().Are(AdapterOut)
                    .Should().NotDependOnAny(DomainService)
                    .AndShould().NotDependOnAny(UseCaseIn)
                    .AndShould().NotDependOnAny(AdapterIn);

                IArchRule useCaseInArchRule =
                   Types().That().Are(UseCaseIn)
                    .Should().NotDependOnAny(DomainService)
                    .AndShould().NotDependOnAny(UseCaseIn)
                    .AndShould().NotDependOnAny(UseCaseOut)
                    .AndShould().NotDependOnAny(AdapterIn)
                    .AndShould().NotDependOnAny(AdapterOut);

                IArchRule useCaseOutArchRule =
                   Types().That().Are(UseCaseOut)
                   .Should().NotDependOnAny(DomainService)
                    .AndShould().NotDependOnAny(UseCaseIn)
                    .AndShould().NotDependOnAny(UseCaseOut)
                    .AndShould().NotDependOnAny(AdapterIn)
                    .AndShould().NotDependOnAny(AdapterOut);

                domainModelArchRule
                    .And(domainServiceArchRule)
                    .And(adapterInArchRule)
                    .And(adapterOutArchRule)
                    .And(useCaseInArchRule)
                    .And(useCaseOutArchRule)
                    .Check(Architecture);
        }
    }
}
