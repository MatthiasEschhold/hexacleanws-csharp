using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;
using Hexacleanws.Vehicle.Test;

namespace Hexacleanws.Test.Clean.Architecture
{
    public class CleanArchitectureAllRingsCheck : BaseTest
    {

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
