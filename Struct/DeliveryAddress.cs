namespace Session01_AssignmentOOP.Struct
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"The delivery address is: city: {City}, street: {Street}, and building number: {BuildingNumber}";
        }
    }
}
