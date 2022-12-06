using System;
using ArchUnitNET.Domain;
using ArchUnitNET.Loader;

namespace Hexacleanws.Vehicle.Test
{
	public class BaseArchTest : BaseTest
	{
        protected const string VEHICLE_MODULE = "Hexacleanws.Vehicle";

        protected static readonly Architecture Architecture =
            new ArchLoader().LoadNamespacesWithinAssembly(typeof(Program).Assembly,
                new string[] { VEHICLE_MODULE }).Build();
    }
}

