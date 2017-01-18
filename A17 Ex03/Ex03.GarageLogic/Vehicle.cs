using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private readonly string r_ModelName;
        private readonly string r_LicensePlateNumber;
        private readonly uint r_NumOfWheels;
        private readonly List<Wheel> r_Wheels;
        protected Engine m_Engine;

        protected Vehicle(string i_LicensePlate, uint i_NumberOfWheels)
        {
            r_LicensePlateNumber = i_LicensePlate;
            r_NumOfWheels = i_NumberOfWheels;
            r_Wheels = new List<Wheel>();
        }
        public uint NumberOfWheelsInVehicle
        {
            get { return r_NumOfWheels; }
        }

        public Engine EngineOfVehicle
        {
            get { return m_Engine; }
        }

        public string LicencePlateNumber
        {
            get { return r_LicensePlateNumber; }
        }

        public List<Wheel> ArrayOfWheels
        {
            get { return r_Wheels; }
        }

        public string ModelName
        {
            get { return r_ModelName; }
        }

        public float EnergyPrecentageLeft
        {
            get { return (m_Engine.CurrentEnergyInVehicle * 100) / m_Engine.MaxEnergy; }
        }

        protected void AddWheels(float i_MaxPressureOfWheels)
        {
            for (int i = 0; i < r_NumOfWheels; i++)
            {
                r_Wheels.Add(new Wheel(i_MaxPressureOfWheels));
            }
        }

        public override string ToString()
        { 
            StringBuilder vehicleInformation = new StringBuilder();
            int wheelIndexer=1;
            vehicleInformation.AppendFormat(
@"
License Number: {0}
Model Name: {1}
", r_LicensePlateNumber, r_ModelName);
            foreach (Wheel wheelInVehicle in r_Wheels)
            {
                vehicleInformation.AppendFormat(
@"Wheel Number: {0}
Wheel Manufacture Name: {1}
Wheel Current Air Pressure: {2}
Wheel Maximum Air Pressure: {3}
", wheelIndexer, wheelInVehicle.ManufacturerName
, wheelInVehicle.CurrentAirPressure, wheelInVehicle.MaxAirPressure);
                wheelIndexer++;
            }

            vehicleInformation.AppendFormat(
@"Current Energy: {0}%
", EnergyPrecentageLeft);
            return vehicleInformation.ToString() + m_Engine.ToString();
            
        }
    }
}
