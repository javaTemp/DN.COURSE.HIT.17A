using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ElectricMotorcycle : Motorcycle
    {
        private const float k_MaxElectricMotorcycleBatteyLife = 2.5f;
        private const float k_MaximumPressureOfWheels = 31f;

        public ElectricMotorcycle(string i_NumberOfPlate) : base(i_NumberOfPlate)
        {
            m_Engine = new EngineRunsOnElectricity(k_MaxElectricMotorcycleBatteyLife);
            AddWheels(k_MaximumPressureOfWheels);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
