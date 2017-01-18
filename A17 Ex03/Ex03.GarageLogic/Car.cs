using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    abstract class Car : Vehicle
    {
        private  eAmountOfDoors m_AmountOfDoorsInCar;
        private  eColor m_ColorOfTheCar;
        private const uint k_CarNumberWheels = 4;

        protected Car(string i_LicensePlate) : base(i_LicensePlate,k_CarNumberWheels)
        {

        }

        public eColor ColorOfCar
        {
            get { return m_ColorOfTheCar; }
            set { m_ColorOfTheCar = value; }
        }

        public eAmountOfDoors DoorsInCar
        {
            get { return m_AmountOfDoorsInCar; }
            set { m_AmountOfDoorsInCar = value; }
        }

        public override string ToString()
        {
            StringBuilder carInformation = new StringBuilder();
            carInformation.AppendFormat(
@"
Number Of Doors: {0}
The Color is: {1}",
m_AmountOfDoorsInCar, m_ColorOfTheCar);
            return base.ToString() + carInformation;
        }

    }
}
