using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    abstract class Motorcycle : Vehicle
    {
        private const uint k_MotorcycleNumberWheels = 2;
        private eTypeOfLicense m_TypeOfLicense;
        private int m_EngineCapacity;

        public Motorcycle(string i_LicensePlate) : base(i_LicensePlate, k_MotorcycleNumberWheels)
        {

        }

        public int EngineCapacity
        {
            get { return m_EngineCapacity; }
            set
            {
                if (value > 0)
                {
                    m_EngineCapacity = value;
                }
                else
                {
                    throw new ArgumentException("The Engine Capacity can not be negative");
                }
            }
        }

        public eTypeOfLicense TypeOfLicense
        {
            get { return m_TypeOfLicense; }
            set { m_TypeOfLicense = value; }
        }

        public override string ToString()
        {
            StringBuilder motorcycleInformatiom = new StringBuilder();
            motorcycleInformatiom.AppendFormat(
@"
License Type: {0}
Engine Capacity: {1}",
m_TypeOfLicense, m_EngineCapacity);
            
            
            return base.ToString() + motorcycleInformatiom.ToString();
        }
    }
}
