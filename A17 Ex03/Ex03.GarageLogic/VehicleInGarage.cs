using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    ///<summary>

    ///</summary>
    class VehicleInGarage
    {
        private readonly Vehicle r_Vehicle;
        private readonly string r_OwnerName;
        private readonly string r_OwnerPhoneNumber;
        private eVehicleStatus m_VehicleStatus;

        public VehicleInGarage(Vehicle i_Vehicle, string i_OwnerName, string i_OwnerPhoneNumber)
        {
            m_VehicleStatus = eVehicleStatus.InRepair;
            r_Vehicle = i_Vehicle;
            r_OwnerName = i_OwnerName;
            r_OwnerPhoneNumber = i_OwnerPhoneNumber;
        }

        public Vehicle Vehicle
        {
            get { return r_Vehicle; }
        }

        public eVehicleStatus VehicleStatus
        {
            get { return m_VehicleStatus; }
            set { m_VehicleStatus = value; }
        }

        public string OwnerName
        {
            get { return r_OwnerName; }
        }

        public string OwnerPhoneNumber
        {
            get { return r_OwnerPhoneNumber; }
        }

        public override string ToString()
        {
            StringBuilder vehicleInGrageInformation = new StringBuilder();
            vehicleInGrageInformation.AppendFormat(
@"
Owner Name: {0}
Owner Phone Number: {1}
The Status In Garge: {2}",
r_OwnerName, r_OwnerPhoneNumber, m_VehicleStatus);
            return vehicleInGrageInformation.ToString();
        }
    }
}
