using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using ArchUnitNET.Fluent;
using Xunit;

using static ArchUnitNET.Fluent.ArchRuleDefinition;
using ArchUnitNET.xUnit;

namespace clean_architecture_mapping_demo.Test.Vehicle.Lab2
{
    public class ArchitectureTest_Task_2_1_2_2 : BaseArchTest
    {

        [Fact]
        public void http_input_adapter_check()
        {
            IArchRule rule = Classes()
                    .That()
                    .HaveName(CONTROLLER_UNDER_TEST)
                    .Should()
                    .ResideInNamespace(ADAPTER_IN)
                    .OrShould()
                    .ResideInNamespace(ADAPTER)
                    .AndShould()
                    .OnlyDependOn(Classes()
                        .That()
                        .ResideInNamespace(DOMAIN_MODEL, true)
                        .And()
                        .ResideInNamespace(DOMAIN, true)
                        .And()
                        .ResideInNamespace(USECASE_IN, true)
                        .And()
                        .ResideInNamespace(USECASE, true)
                        .And()
                        .ResideInNamespace(ADAPTER_IN, true)
                        .And()
                        .ResideInNamespace(ADAPTER, true));

            rule.Check(Architecture);
        }

        [Fact]
        public void usecase_in_check()
        {
            IArchRule rule = Classes()
                    .That()
                    .HaveName(USECASE_IN_QUERY_UNDER_TEST)
                    .Should()
                    .ResideInNamespace(USECASE)
                    .OrShould()
                    .ResideInNamespace(USECASE_IN)
                    .AndShould()
                    .OnlyDependOn(Classes()
                        .That()
                        .ResideInNamespace(DOMAIN_MODEL, true)
                        .And()
                        .ResideInNamespace(DOMAIN, true));
            rule.Check(Architecture);
        }

        [Fact]
        public void usecase_in_implementation_check()
        {
            IArchRule rule = Classes()
                    .That()
                    .HaveName(SERVICE_UNDER_TEST)
                    .Should()
                    .ResideInNamespace(DOMAIN)
                    .OrShould()
                    .ResideInNamespace(DOMAIN_SERVICE)
                    .AndShould()
                    .ImplementInterface("Vehicle.UseCase.In.VehiceQuery", true);
            rule.Check(Architecture);
        }
    }


}

