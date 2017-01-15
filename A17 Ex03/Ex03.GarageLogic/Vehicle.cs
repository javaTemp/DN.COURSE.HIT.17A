using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        private readonly string r_ModelName;
        private readonly string r_LicencePlateNumber;
        private readonly uint r_NumOfWheels;
        //private float m_EnergyPrecentageLeft;
        private readonly List<Wheel> r_Wheels;
        private Engine m_Engine;

        public Vehicle(string i_ModelName, string i_LicencePlate, uint i_NumberOfWheels)
        {
            r_ModelName = i_ModelName;
            r_LicencePlateNumber = i_LicencePlate;
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
            set { m_Engine = value; }
        }

        public string LicencePlateNumber
        {
            get { return r_LicencePlateNumber; }
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

        public override string ToString()
        { 
            StringBuilder vehicleInformation = new StringBuilder();

            return vehicleInformation;
//            vehicleInformation.AppendFormat( /////////// TODO
//@""
        }
    }
}
