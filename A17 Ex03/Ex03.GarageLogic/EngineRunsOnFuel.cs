using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class EngineRunsOnFuel : Engine
    {
        private readonly eFuelType r_EngineFuelType;

        public EngineRunsOnFuel (eFuelType i_EngineFuelType, float i_MaxEngineCapacity) : base(i_MaxEngineCapacity)
        {
            r_EngineFuelType = i_EngineFuelType;
        }

        public eFuelType FuelType
        {
            get { return r_EngineFuelType; }
        }

        public void EngineFuelFill(eFuelType i_FuelType, string i_AmountToFillInEngine)
        {
            if (i_FuelType == r_EngineFuelType)
            {
                float amountToFillInEngine;
                float amountOfRemainingLiters = MaxEnergy - CurrentEnergyInVehicle;
                bool trueInput = float.TryParse(i_AmountToFillInEngine, out amountToFillInEngine);
                if (trueInput)
                {
                    if (amountToFillInEngine < 0)
                    {
                        throw new ArgumentException("Can not fill negative number of liters to the tank");
                    }
                    if (amountToFillInEngine < amountOfRemainingLiters)
                    {
                        CurrentEnergyInVehicle += amountToFillInEngine;
                    }
                    else
                    {
                        throw new ValueOutOfRangeException(0, MaxEnergy, "you are trying to fill above the max fuel tank");
                    }
                }
                else
                {
                    throw new FormatException("invalid input, the input should be a number!!");
                }
            }
            else
            {
                throw new ArgumentException("the fuel type is not correct");
            }
        }

        public override string ToString()
        {
            StringBuilder engineOnFuelInfo = new StringBuilder();
            engineOnFuelInfo.AppendFormat(
@"Fuel Type: {0}
Maximum Fuel Tank: {1}
The Amount Of Liters In The Tank : {2}",
r_EngineFuelType, MaxEnergy, CurrentEnergyInVehicle);
            return engineOnFuelInfo.ToString();
        }
    }
}
