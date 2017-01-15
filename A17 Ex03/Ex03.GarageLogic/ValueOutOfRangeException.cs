using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class ValueOutOfRangeException : Exception
    {
        private readonly float r_MinValue;
        private readonly float r_MaxValue;
        
        public float MinValue
        {
            get { return r_MinValue; }
        }
        
        public float MaxValue
        {
            get { return r_MaxValue; }
        } 

        public ValueOutOfRangeException(
            float i_MinValue,
            float i_MaxValue,
            string i_Message)
            : base (i_Message)
        {
            this.r_MinValue = i_MinValue;
            this.r_MaxValue = i_MaxValue;
        }
    }
}
