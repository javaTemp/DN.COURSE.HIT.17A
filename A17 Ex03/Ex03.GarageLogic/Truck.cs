using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    abstract class Truck : Vehicle
    {
        private const uint k_TruckNumberWheels = 12;
        private bool m_HasDangerousCargo;
        private float m_MaximumLuggageWeight;

        protected Truck(string i_LicensePlate) : base(i_LicensePlate, k_TruckNumberWheels)
        {
        }

        public float MaxLuggageWeight
        {
            get { return m_MaximumLuggageWeight; }
            set
            {
                if (value > 0)
                {
                    m_MaximumLuggageWeight = value;
                }
                else
                {
                    throw new ArgumentException("You Can Not Set The Maximum Luggage Weight With Negative Value");
                }
            }
        }

        public bool HasDangerousCargo
        {
            get { return m_HasDangerousCargo; }
            set { m_HasDangerousCargo = value; }
        }

        public override string ToString()
        {
            StringBuilder truckInformation = new StringBuilder();
            truckInformation.AppendFormat(
@"
Carrying Dangerous Cargo: {0}
Maximum Carrying Luggage: {1}",
m_HasDangerousCargo, m_MaximumLuggageWeight);

            return base.ToString() + truckInformation;
        }
    }
}
