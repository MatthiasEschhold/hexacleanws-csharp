using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using Hexacleanws.Source.Vehicle.Adapter.In;
using Hexacleanws.Source.Vehicle.Adapter.Out;
using Hexacleanws.Source.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Test
{
    public class BaseTest
    {
        protected const String DOMAIN = "..domain..";
        protected const String DOMAIN_SERVICE = "..domain.service..";
        protected const String DOMAIN_MODEL = "..domain.model..";
        protected const String JAVA_LANG = "..java.lang..";
        protected const String ROOT_ENTITY_UNDER_TEST = "VehicleRootEntity";
        protected const String DB_ENTITY_UNDER_TEST = "VehicleDbEntity";
        protected const String SERVICE_UNDER_TEST = "VehicleService";
        protected const String VALUE_OBJECT_UNDER_TEST = "Vin";
        protected const String JAVA_UTIL = "..java.util..";
        protected const String ORG = "..org..";
        protected const String VIN = "WP0ZZZ99ZTS392155";
        protected const String ADAPTER_IN = "..adapter.in..";
        protected const String ADAPTER = "..adapter..";
        protected const String USECASE = "..usecase..";
        protected const String USECASE_IN = "..usecase.in..";
        protected const String USECASE_OUT = "..usecase.out..";
        protected const String USECASE_OUT_QUERY_UNDER_TEST = "VehicleDbQuery";
        protected const String USECASE_IN_QUERY_UNDER_TEST = "VehicleQuery";
        protected const String REPOSITORY_UNDER_TEST = "VehicleRepository";
        protected const String ADAPTER_OUT = "..adapter.out..";
        protected const String CONTROLLER_UNDER_TEST = "VehicleController";
        protected const String LICENSE_PLATE_TEST_VALUE = "ES-EM 385";
        protected const double MILEAGE_TEST_VALUE = 100000;
        protected const String REGISTRATION_COUNTRY_TEST_VALUE = "DE-de";
        protected const String VEHICLE_MODEL_DESCRIPTION_TEST_VALUE = "E30 Limousine";
        protected const String VEHICLE_MODEL_TYPE_TEST_VALUE = "3er";
        protected const String SERIAL_NUMBER_TEST_VALUE = "0123456789";
        protected const String IGNORED_SYSTEM_DEPENDENCY = "System";

        protected const string VEHICLE_MODULE = "Hexacleanws.Source.Vehicle";

        protected static readonly Architecture Architecture =
            new ArchLoader().LoadNamespacesWithinAssembly(typeof(Program).Assembly,
                new string[] { VEHICLE_MODULE }).Build();

        protected VehicleRootEntity CreateVehicle()
        {
            return new VehicleRootEntity(new Vin(VIN));
        }

    }
}

