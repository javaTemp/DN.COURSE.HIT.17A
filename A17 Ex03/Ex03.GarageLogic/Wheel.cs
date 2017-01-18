using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Wheel
    {
        private string m_ManufacturerName;
        private float m_CurrentAirPressure;
        private readonly float r_MaxAirPressure;
        private const float k_TrashedValueOfCurrentAirPressure = 0;

        public Wheel(float i_MaxAirPressure)
        {
            this.r_MaxAirPressure = i_MaxAirPressure;
            this.m_CurrentAirPressure = k_TrashedValueOfCurrentAirPressure;
        }
        
        public string ManufacturerName
        {
            get { return m_ManufacturerName; }
            set { m_ManufacturerName = value; }
        }

        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
            set
            {
                if (value >= 0 && value <= r_MaxAirPressure)
                {
                    m_CurrentAirPressure = value;
                }
                else
                {
                    if (value < 0)
                    {
                        throw new ValueOutOfRangeException(0, r_MaxAirPressure, "you can fill less that the 0");
                    }

                    if (value > r_MaxAirPressure)
                    {
                        throw new ValueOutOfRangeException(0, r_MaxAirPressure, "you can not fill more than MaxAirPressure");
                    }
                }
            }
        }

        public float MaxAirPressure
        {
            get { return r_MaxAirPressure; }
            
        }

        //private float airpressuredelta()
        //{
        //    return r_maxairpressure - m_currentairpressure;
        //}

        public void InflateWheel(float i_AirPressureToAdd) // change to bool if necessary
        {
            string ExMsg;
            if (i_AirPressureToAdd >= 0)
            {
                if (m_CurrentAirPressure + i_AirPressureToAdd <= r_MaxAirPressure)
                {
                    m_CurrentAirPressure = m_CurrentAirPressure + i_AirPressureToAdd;
                }
                else
                {
                    ExMsg = "Air presurre is above the max air pressure allowed.";
                    throw new ValueOutOfRangeException(0, r_MaxAirPressure, ExMsg);
                }
            }
            else
            {
                ExMsg = "Air pressure supplied is below zero.";
                throw new ValueOutOfRangeException(0, r_MaxAirPressure, ExMsg);
            }
            //return;
        }

        public override string ToString()
        {
            StringBuilder wheelInformation = new StringBuilder();
            wheelInformation.AppendFormat(
@"Wheel Manufacturer Name: {0}
Air Pressure in Wheel: {1}", m_ManufacturerName, m_CurrentAirPressure);

            return wheelInformation.ToString();
        }
    }
}
