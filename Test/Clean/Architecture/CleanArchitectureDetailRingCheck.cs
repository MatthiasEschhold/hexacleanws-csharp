using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;
using Hexacleanws.Vehicle.Test;

namespace Hexacleanws.Test.Clean.Architecture
{
    public class CleanArchitectureDetailRingCheck : BaseTest
    {


        [Fact]
        public void should_check_domain_service_ring()
        {
            IArchRule rule = Types().That().HaveFullNameContaining("Domain.Service")
                    .Should().NotDependOnAny(Types().That().HaveFullNameContaining("Adapter.In"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("Adapter.Out"));
            rule.Check(Architecture);
        }

        [Fact]
        public void should_check_domain_model_ring()
        {
            IArchRule rule = Types().That().HaveFullNameContaining("Domain.Model")
                    .Should().NotDependOnAny(Types().That().HaveFullNameContaining("Adapter.In"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("Adapter.Out"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("Domain.Service"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("UseCase.In"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("UseCase.Out"));
            rule.Check(Architecture);
        }

        [Fact]
        public void should_check_adapter_in_ring()
        {
            IArchRule rule = Types().That().HaveNameEndingWith("Adapter.In")
                    .Should().NotDependOnAny(Types().That().HaveFullNameContaining("Domain.Service"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("UseCase.Out"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("Adapter.Out"));
            rule.Check(Architecture);
        }

        [Fact]
        public void should_check_adapter_out_ring()
        {
            IArchRule rule = Types().That().HaveNameEndingWith("Repository")
                .Or().HaveNameEndingWith("ServiceClient")
                    .Should().ImplementInterface("UseCase.Out", true)
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("Domain.Service"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("UseCase.In"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("Adapter.In"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("Application.Service"));
            rule.Check(Architecture);
        }

        [Fact]
        public void should_check_adapter_mapper()
        {
            IArchRule rule = Types().That().HaveNameEndingWith("Mapper")
                    .Should().NotDependOnAny(Types().That().HaveFullNameContaining("Domain.Service"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("UseCase.In"))
                    .AndShould().NotDependOnAny(Types().That().HaveFullNameContaining("UseCase.Out"));
            rule.Check(Architecture);
        }

    }
}
