using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class EngineRunsOnElectricity : Engine
    {
        public EngineRunsOnElectricity (float i_MaxBatteryLife) : base(i_MaxBatteryLife)
        {

        }

        public void EngineBatteryFill(string i_AmountToFill)
        {
            float amountToFill;
            bool trueInput = float.TryParse(i_AmountToFill, out amountToFill);
            if (trueInput)
            {
                if (amountToFill < 0)
                {
                    throw new ArgumentException("can not charge the battary with negative number");
                }
                if (amountToFill < MaxEnergy - CurrentEnergyInVehicle)
                {
                    CurrentEnergyInVehicle += amountToFill;
                }
                else
                {
                    throw new ValueOutOfRangeException(0, MaxEnergy, "you are trying to charge above the maximum charging");
                }
            }
            else
            {
                throw new ArgumentException("invalid input, the input should be a number!!");
            }
        }
        public override string ToString()
        {
            StringBuilder engineOnFuelInfo = new StringBuilder();
            engineOnFuelInfo.AppendFormat(
@"Maximum Battary life in Hours: {0}
The Current  Battary Time : {1}%",
 MaxEnergy, CurrentEnergyInVehicle);
            return engineOnFuelInfo.ToString();
        }
    }
}
