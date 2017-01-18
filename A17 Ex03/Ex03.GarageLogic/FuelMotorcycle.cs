using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class FuelMotorcycle : Motorcycle
    {
        private const float k_MaximumPressureOfWheels = 31f;
        private const float k_MotorcycleTankMaxCapacity = 6.2f;
        private const eFuelType k_MotorcycleFuelType = eFuelType.Octan98;

        public FuelMotorcycle(string i_NumberOfPlate)
            : base(i_NumberOfPlate)
        {
            m_Engine = new EngineRunsOnFuel(k_MotorcycleFuelType, k_MotorcycleTankMaxCapacity);
            AddWheels(k_MaximumPressureOfWheels);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
