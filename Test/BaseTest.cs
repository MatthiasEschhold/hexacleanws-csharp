using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using Hexacleanws.Source.Vehicle.Adapter.In;
using Hexacleanws.Source.Vehicle.Adapter.In.Web;
using Hexacleanws.Source.Vehicle.Adapter.Out.db;
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

        protected VehicleRootEntity CreateVehicleWithoutMasterData()
        {
            return new VehicleRootEntity(new Vin(VIN), CreateVehicleMotionData());
        }
        protected VehicleRootEntity CreateVehicle()
        {
            return new VehicleRootEntity(new Vin(VIN), CreateVehicleMotionData(), CreateVehicleMasterData());
        }

        protected VehicleMasterData CreateVehicleMasterData()
        {
            return new VehicleMasterData(CreateEquipmentList(),
                new VehicleModel(VEHICLE_MODEL_DESCRIPTION_TEST_VALUE, VEHICLE_MODEL_TYPE_TEST_VALUE),
                new SerialNumber(SERIAL_NUMBER_TEST_VALUE), new MileageUnit(MileageUnitValue.KM));
        }

        protected List<Equipment> CreateEquipmentList()
        {
            List<Equipment> equipmentList = new List<Equipment> {
            CreateEquipment("LT317", "Live Traffic"),
            CreateEquipment("GS200", "2G Adapter"),
            CreateEquipment("KL457", "Sport Chassis M Deluxe")};
            return equipmentList;
        }

        private Equipment CreateEquipment(String code, String description)
        {
            return new Equipment(new EquipmentCode(code),  description);
        }

        protected VehicleMotionData CreateVehicleMotionData()
        {
            return new VehicleMotionData(
                new LicensePlate(LICENSE_PLATE_TEST_VALUE),
                new Mileage(MILEAGE_TEST_VALUE));
        }

        protected VehicleDbEntity CreateVehicleDbEntity()
        {
            VehicleDbEntity dbEntity = new VehicleDbEntity();
            dbEntity.Vin = VIN;
            dbEntity.LicensePlate = LICENSE_PLATE_TEST_VALUE;
            dbEntity.Mileage = MILEAGE_TEST_VALUE;
            return dbEntity;
        }

        protected VehicleResource CreateVehicleResource()
        {
            VehicleResource vehicle = new VehicleResource();
            vehicle.Vin = VIN;
            vehicle.VehicleModelType = VEHICLE_MODEL_TYPE_TEST_VALUE;
            vehicle.VehicleModelName = VEHICLE_MODEL_DESCRIPTION_TEST_VALUE;
            vehicle.SerialNumber = SERIAL_NUMBER_TEST_VALUE;
            vehicle.MileageUnit = MileageUnitValue.KM.ToString();
            vehicle.equipmentList = CreateEquipmentResourceList();
            vehicle.LicensePlate = LICENSE_PLATE_TEST_VALUE;
            return vehicle;
        }

        protected List<EquipmentResource> CreateEquipmentResourceList()
        {
            List<EquipmentResource> equipmentList = new List<EquipmentResource> {
            CreateEquipmentResource("LT317", "Live Traffic"),
            CreateEquipmentResource("GS200", "2G Adapter"),
            CreateEquipmentResource("KL457", "Sport Chassis M Deluxe")};
            return equipmentList;
        }

        private EquipmentResource CreateEquipmentResource(string code, string description)
        {
            EquipmentResource equipment = new EquipmentResource();
            equipment.Code = code;
            equipment.Description = description;
            return equipment;
        }

    }
}

