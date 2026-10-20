using System;
using System.Collections.Generic;
using System.Text;

namespace Session01_AssignmentOOP
{
    internal struct DeliveryCenter
    {
        Shipment[] shipment;
        public DeliveryCenter()
        {
            shipment = new Shipment[10];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipment.Length)
                    return shipment[index];

                return default;
            }
            set
            {
                if (index >= 0 && index < shipment.Length)
                    shipment[index] = value;
            }
        }
        public Shipment? this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                    if (shipment[i].TrackingCode == trackingCode)
                        return shipment[i];
                return default;
            }
        }
        public bool AddShipment(Shipment ship, int position)
        {
            if (position < shipment.Length)
            {
                shipment[position] = ship;
                return true;
            }
            else
                return false;
        }
    }
}
