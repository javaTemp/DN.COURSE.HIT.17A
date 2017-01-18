using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class GarageManager
    {
        private readonly Dictionary<string, VehicleInGarage> r_VehiclesInGarage = new Dictionary<string, VehicleInGarage>();

        public Dictionary<string, VehicleInGarage> VehiclesInGarage
        {
            get { return r_VehiclesInGarage; }
        }

        public void FillElectricEnergy(string i_LicenseNumber, string i_AmountToCharge)
        {
            EngineRunsOnElectricity engineOnElecticity = 
                r_VehiclesInGarage[i_LicenseNumber].Vehicle.EngineOfVehicle as EngineRunsOnElectricity;
            engineOnElecticity.EngineBatteryFill(i_AmountToCharge);
        }

        public void FillFuelToTank(eFuelType i_FuelType, string i_LicenseNumber, string i_AmountToFill)
        {
            EngineRunsOnFuel engineOnFuel = 
                r_VehiclesInGarage[i_LicenseNumber].Vehicle.EngineOfVehicle as EngineRunsOnFuel;
            engineOnFuel.EngineFuelFill(i_FuelType, i_AmountToFill);
        }

        public void FillAirPressureToMaximum(string i_LicenseNumber)
        {
            foreach (Wheel wheel in r_VehiclesInGarage[i_LicenseNumber].Vehicle.ArrayOfWheels)
            {
                wheel.InflateWheel(wheel.MaxAirPressure - wheel.CurrentAirPressure);
            }
        }

        public void CheckingCorrectRangeOfValueOfEngine(Vehicle i_Vehicle, string i_ValueToCheck)
        {
            float FloatValue;
            if (float.TryParse(i_ValueToCheck, out FloatValue))
            {
                i_Vehicle.EngineOfVehicle.CurrentEnergyInVehicle = FloatValue;
            }
            else
            {
                throw new ArgumentException("the input is not correct");
            }
        }

        public bool CheckIfVehicleRgisteredInGarage(string i_LicenseNumber)
        {
            bool hasVehicleInGarage = false;
            if (r_VehiclesInGarage.ContainsKey(i_LicenseNumber))
            {
                hasVehicleInGarage = true;
            }
            return hasVehicleInGarage;
        }
        public void AddToGarage(VehicleInGarage i_Vehicle)
        {
            r_VehiclesInGarage.Add(i_Vehicle.Vehicle.LicencePlateNumber, i_Vehicle);
        }

    }
}
