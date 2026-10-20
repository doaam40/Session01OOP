using System;
using System.Collections.Generic;
using System.Text;

namespace Session01_AssignmentOOP
{
    internal struct Shipment
    {
        string trackingCode;
        string description;
        double weight;
        decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }
        public decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5);


        public Shipment(string _trackingCode)
        {
            TrackingCode = _trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;
        }
        public Shipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination)
        {
            TrackingCode = _trackingCode;
            Description = _description;
            Weight = _weight;
            DeliveryFee = _deliveryFee;
            Destination = _destination;
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }
        public void PrintShipment()
        {
            Console.WriteLine($"Shipment information: tracking code is {TrackingCode}, description: {Description}, weight: {Weight}, delivery fee: {DeliveryFee}, and estimatedCost: {EstimatedCost}");
        }
        public override string ToString()
        {
            return $"Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Destination: {Destination.BuildingNumber} {Destination.Street} Street, {Destination.City}, Estimated Cost: {EstimatedCost} EGP";
        }
    }
}
