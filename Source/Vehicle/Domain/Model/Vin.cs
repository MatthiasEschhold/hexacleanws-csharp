using System;

namespace clean_architecture_mapping_demo.Source.Vehicle.Domain.Model
{
	public class Vin
	{
		public String value { get;}

        public Vin(String value)
		{
			this.value = value;
			if(this.value == null)
			{
				throw new Exception("Vin should not be null");
			}
		}
	}
}

