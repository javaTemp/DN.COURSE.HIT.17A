using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    static class CreationOfVehicle
    {
        public static Vehicle CreateVehicle(eTypeOfVehicle i_TypeOfVehicle, string i_LicenseNumber)
        {
            Vehicle newVehicleToCreate = null;
            switch (i_TypeOfVehicle)
            {
                case eTypeOfVehicle.ElectricCar:
                    newVehicleToCreate = new ElectricCar(i_LicenseNumber);
                    break;
                case eTypeOfVehicle.ElectricMotorcycle:
                    newVehicleToCreate = new ElectricMotorcycle(i_LicenseNumber);
                    break;
                case eTypeOfVehicle.FuelTruck:
                    newVehicleToCreate = new FuelTruck(i_LicenseNumber);
                    break;
                case eTypeOfVehicle.FuelCar:
                    newVehicleToCreate = new FuelCar(i_LicenseNumber);
                    break;
                case eTypeOfVehicle.FuelMotorcycle:
                    newVehicleToCreate = new FuelMotorcycle(i_LicenseNumber);
                    break;
            }

            return newVehicleToCreate;
        }
    }
}
