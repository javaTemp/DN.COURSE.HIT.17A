using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class FuelTruck : Truck
    {
        private const float k_MaximumPressureOfWheels = 26f;
        private const eFuelType k_TruckFuelType = eFuelType.Octan96;
        private const float k_TruckTankMaxCapacity = 150f;

        public FuelTruck(string i_LicensePlate) : base(i_LicensePlate)
        {
            m_Engine = new EngineRunsOnFuel(k_TruckFuelType, k_TruckTankMaxCapacity);
            AddWheels(k_MaximumPressureOfWheels);
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
