using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class FuelCar : Car
    {
        private const float k_MaximumPressureOfWheels = 32f;
        private const eFuelType k_CarFuelType = eFuelType.Octan95;
        private const float k_CarTankMaxCapacity = 46f;

        public FuelCar(string i_NumberOfPlate) : base(i_NumberOfPlate)
        {
            m_Engine = new EngineRunsOnFuel(k_CarFuelType, k_CarTankMaxCapacity);
            AddWheels(k_MaximumPressureOfWheels);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
