using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Engine
    {
        private readonly float r_MaxEnergy;
        private float m_EnergyLeft;

        public Engine(float i_MaxEnergy)
        {
            r_MaxEnergy = i_MaxEnergy;
            m_EnergyLeft = 0;
        }

        public float MaxEnergy
        {
            get { return r_MaxEnergy; }
        }

        public float CurrentEnergyInVehicle
        {
            get { return m_EnergyLeft; }
            set
            {
                if (value >= 0 && value <= r_MaxEnergy)
                {
                    m_EnergyLeft = value;
                }
                else
                {
                    throw new ValueOutOfRangeException(0, r_MaxEnergy, "the input is out of range");
                }
            }
        }

    }
}
