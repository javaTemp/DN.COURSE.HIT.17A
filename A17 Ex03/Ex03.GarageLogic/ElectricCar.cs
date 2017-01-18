using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ElectricCar : Car
    {
        private const float k_MaxElectricCarBatteyLife = 2.7f;
        private const float k_MaximumPressureOfWheels = 32f;

        public ElectricCar(string i_NumberOfPlate) : base(i_NumberOfPlate)
        {
            m_Engine = new EngineRunsOnElectricity(k_MaxElectricCarBatteyLife);
            AddWheels(k_MaximumPressureOfWheels);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
