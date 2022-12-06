using Hexacleanws.Vehicle.Adapter.In.Web;
using Hexacleanws.Vehicle.Adapter.Out.Db;
using Hexacleanws.Vehicle.Domain.dto;
using Hexacleanws.Vehicle.Domain.Model;

namespace Hexacleanws.Vehicle.Test
{
    public class BaseTest
    {
        protected const string ROOT_PACKAGE = "com.hexaclean.arc.demo";
        protected const string DOMAIN = "..domain..";
        protected const string DOMAIN_SERVICE = "..domain.service..";
        protected const string DOMAIN_MODEL = "..domain.model..";
        protected const string JAVA_LANG = "..java.lang..";
        protected const string ROOT_ENTITY_UNDER_TEST = "Vehicle";
        protected const string DB_ENTITY_UNDER_TEST = "VehicleDbEntity";
        protected const string SERVICE_UNDER_TEST = "VehicleService";
        protected const string VALUE_OBJECT_UNDER_TEST = "Vin";
        protected const string JAVA_UTIL = "..java.util..";
        protected const string ORG = "..org..";
        protected const string VIN = "WP0ZZZ99ZTS392155";
        protected const string ADAPTER_IN = "..adapter.in..";
        protected const string ADAPTER = "..adapter..";
        protected const string USECASE = "..usecase..";
        protected const string USECASE_IN = "..usecase.in..";
        protected const string USECASE_OUT = "..usecase.out..";
        protected const string USECASE_OUT_QUERY_UNDER_TEST = "VehicleDbQuery";
        protected const string USECASE_IN_QUERY_UNDER_TEST = "VehicleQuery";
        protected const string REPOSITORY_UNDER_TEST = "VehicleRepository";
        protected const string ADAPTER_OUT = "..adapter.out..";
        protected const string CONTROLLER_UNDER_TEST = "VehicleController";
        protected const string LICENSE_PLATE_TEST_VALUE = "ES-EM 385";
        protected const double MILEAGE_TEST_VALUE = 100000;
        protected const string REGISTRATION_COUNTRY_TEST_VALUE = "DE-de";
        protected const string VEHICLE_MODEL_DESCRIPTION_TEST_VALUE = "E30 Limousine";
        protected const string VEHICLE_MODEL_TYPE_TEST_VALUE = "3er";
        protected const string SERIAL_NUMBER_TEST_VALUE = "0123456789";

        protected VehicleRootEntity CreateVehicleWithoutMasterData()
        {
            return new VehicleRootEntity(new Vin(VIN), CreateVehicleMotionData());
        }
        protected VehicleRootEntity CreateVehicle()
        {
            return new VehicleRootEntity(new Vin(VIN), CreateVehicleMotionData(), CreateVehicleMasterData(), true);
        }

        protected VehicleMasterData CreateVehicleMasterData()
        {
            return new VehicleMasterData(new VehicleModel(VEHICLE_MODEL_DESCRIPTION_TEST_VALUE, VEHICLE_MODEL_TYPE_TEST_VALUE),
                new SerialNumber(SERIAL_NUMBER_TEST_VALUE), new MileageUnit(MileageUnitValue.KM));
        }

        protected VehicleMasterDataDomainDto CreateVehicleMasterDataDto()
        {
            return new VehicleMasterDataDomainDto(CreateEquipmentList(), 
                new VehicleModel(VEHICLE_MODEL_DESCRIPTION_TEST_VALUE, VEHICLE_MODEL_TYPE_TEST_VALUE),
                new SerialNumber(SERIAL_NUMBER_TEST_VALUE), new MileageUnit(MileageUnitValue.KM));
        }

        protected VehicleMasterDataDomainDto CreateVehicleMasterDataWithout2GSupport()
        {
            return new VehicleMasterDataDomainDto(CreateEquipmentListWithout2GSupport(),
                new VehicleModel(VEHICLE_MODEL_DESCRIPTION_TEST_VALUE, VEHICLE_MODEL_TYPE_TEST_VALUE),
                new SerialNumber(SERIAL_NUMBER_TEST_VALUE), new MileageUnit(MileageUnitValue.KM));
        }

        private List<string> CreateEquipmentListWithout2GSupport()
        {
            List<string> equipmentList = new List<string> {
                "LT317",
                "KL457"
            };

            return equipmentList;
        }
        protected List<string> CreateEquipmentList()
        {
            List<string> equipmentList = new List<string> {
                "LT317",
                "KL457",
                "GS200"
            };

            return equipmentList;
        }

        protected VehicleMotionData CreateVehicleMotionData()
        {
            return new VehicleMotionData(
                new LicensePlate(LICENSE_PLATE_TEST_VALUE), 
                new Mileage(MILEAGE_TEST_VALUE));
        }

        protected VehicleMotionDataResource CreateVehicleMotionDataResource()
        {
            VehicleMotionDataResource resource = new VehicleMotionDataResource();
            resource.Mileage = MILEAGE_TEST_VALUE;
            resource.LicensePlate = LICENSE_PLATE_TEST_VALUE;
            return resource;
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
            vehicle.SerialNumber = SERIAL_NUMBER_TEST_VALUE;
            vehicle.LicensePlate = LICENSE_PLATE_TEST_VALUE;
            vehicle.VehicleModelDescription = VEHICLE_MODEL_DESCRIPTION_TEST_VALUE;
            vehicle.VehicleModelName = VEHICLE_MODEL_TYPE_TEST_VALUE;
            vehicle.Mileage = MILEAGE_TEST_VALUE;
            vehicle.MileageUnit = MileageUnitValue.KM.ToString();
            //equipment list
            return vehicle;
        }
    }
}

