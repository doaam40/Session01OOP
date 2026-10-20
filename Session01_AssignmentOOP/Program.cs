namespace Session01_AssignmentOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1
            // a) the DeliveryAddress variable is struct (value type) so its new copy has the value of DeliveryAddress variable,
            // and when the copy is modifed so the copy only has the modify but DeliveryAddress variable has its same value not
            // changed

            // b) the Customer variable is class (reference type) so its new copy refere to the same object that Customer variable
            // refere to, and when one variable modifies the object so the two variables will be modified
            #endregion

            #region Q2
            // a) 1- any change in the variables name will appear out to all solution,
            //    2- we can not make validation on fields,
            //    3- we can not allow getter and prevent setter and vise versa

            // b) when we make fields private so no class can show them, and propirtes only will be shown, so any modification in fields
            // will not be shown outside, we can make validations in properties, and can allow getter and prevent setter and vise versa
            #endregion

            #endregion

            #region Part 02 : Practical

            #region Q1
            //DeliveryAddress deliveryAddress1 = new DeliveryAddress("Cairo", "AL-Nasr", 10);
            //DeliveryAddress deliveryAddress2 = deliveryAddress1;
            //deliveryAddress2.City = "Alex";
            //deliveryAddress2.Street = "Tahrir";
            //deliveryAddress2.BuildingNumber = 40;
            //Console.WriteLine(deliveryAddress1.GetFullAddress());
            //Console.WriteLine(deliveryAddress2.GetFullAddress());
            #endregion

            #region Q2
            #endregion

            #region Q5
            #endregion

            #region Q6
            bool flag;
            string trackingCode;
            string description;
            double weight;
            decimal deliveryFee;
            string city;
            string street;
            int buildingNumber;
            bool shipmentAdded;

            DeliveryCenter deliveryCenter = new DeliveryCenter();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"Enter Shipment {i + 1} Data");
                Console.Write("Tracking Code: ");
                trackingCode = Console.ReadLine();
                Console.Write("Description: ");
                description = Console.ReadLine();
                do
                {
                    Console.Write("Weight: ");
                    flag = double.TryParse(Console.ReadLine(), out weight);
                } while (!flag);

                do
                {
                    Console.Write("Delivery Fee: ");
                    flag = decimal.TryParse(Console.ReadLine(), out deliveryFee);
                } while (!flag);

                Console.Write("City: ");
                city = Console.ReadLine();
                Console.Write("Street: ");
                street = Console.ReadLine();
                do
                {
                    Console.Write("Building Number: ");
                    flag = int.TryParse(Console.ReadLine(), out buildingNumber);
                } while (!flag);

                Shipment shipment = new Shipment(trackingCode, description, weight, deliveryFee, new DeliveryAddress(city, street, buildingNumber));
                shipmentAdded = deliveryCenter.AddShipment(shipment, i);
                string printStatus = shipmentAdded ? "The shipment was added successfully" : "The delivery center is full";
                Console.WriteLine(printStatus);
            }

            Console.WriteLine("All Shipments");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(deliveryCenter[i]);
            }

            Console.Write("Enter a tracking code to search: ");
            Shipment? ship = deliveryCenter[Console.ReadLine()];
            string printShipment = ship is not null ? $"Shipment found: {ship}" : "Shipment not found";
            Console.WriteLine(printShipment);

            DeliveryAddress address01 = new DeliveryAddress("Cairo", "Tahrir", 15);
            DeliveryAddress address02 = address01;
            address02.Street = "Makram Ebeid";
            address02.BuildingNumber = 20;
            Console.WriteLine($"Original Address: {address01.GetFullAddress()}");
            Console.WriteLine($"Copied Address: {address02.GetFullAddress()}");

            #endregion


            #endregion
        }
    }
}
