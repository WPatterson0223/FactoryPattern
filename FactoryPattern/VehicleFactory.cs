using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		
		public static IVehicle GetVehicle(int tires)
		{
			switch (tires)
			{
				case 2:
					return new Motorcycle();
				case 4:
					return new Car();
				default:
					return new Car();
			}
		}
	}
}

