namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            /// Q1  Abstraction
            ///a)  What is Abstraction in Object - Oriented Programming?
            ///b)  Why is abstraction considered one of the four pillars of OOP ?

            // a) Abstraction is the process of hiding unnecesssary implementation details and showing only the essential features of an object

            // b) Because it helps reduce Complexity by hiding implementation details and exposing only what is necessary for using the object

            /// Q2  Abstract Classes vs. Interfaces
            /// a)  What is the difference between an Abstract Class and an Interface?
            /// b)  When would you choose an Interface instead of an Abstract Class?
            /// c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            // a) An abstract class can have both abstract and concrete methods,
            // while an interface can only have abstract methods (prior to C# 8.0).
            // Abstract classes can have fields, constructors, and access modifiers, while interfaces cannot.

            // b) You would choose an interface when you want to define a contract that multiple classes can implement,
            // regardless of their position in the class hierarchy.

            // c) No, a class cannot inherit from multiple abstract classes, but it can implement multiple interfaces.


            #endregion

            #region Part 02 — Practical
            // Driver
            Driver driver = new Driver(
                1,
                "Ahmed Mohamed",
                "01012345678"
            );

            // Delivery Center
            DeliveryCenter center =
                new DeliveryCenter("Smart Delivery Center");

            center.Driver = driver;

            // Address 1
            DeliveryAddress address1 =
                new DeliveryAddress(
                    "Cairo",
                    "Tahrir Street",
                    15
                );

            // Address 2
            DeliveryAddress address2 =
                new DeliveryAddress(
                    "Cairo",
                    "Nasr City",
                    20
                );

            // Address 3
            DeliveryAddress address3 =
                new DeliveryAddress(
                    "Berlin",
                    "Main Street",
                    10
                );

            // Standard Shipment
            StandardShipment standard =
                new StandardShipment(
                    "SH001",
                    "Laptop",
                    3,
                    80,
                    address1
                );

            // Express Shipment
            ExpressShipment express =
                new ExpressShipment(
                    "SH002",
                    "Mobile Phone",
                    2,
                    60,
                    address2,
                    30
                );

            // International Shipment
            InternationalShipment international =
                new InternationalShipment(
                    "SH003",
                    "Television",
                    8,
                    120,
                    address3,
                    "Germany",
                    100
                );

            // Add shipments
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");

            Console.WriteLine("Driver : " + center.Driver.FullName);
            Console.WriteLine("------------------------------------------");

            // Print all shipments
            center.PrintAllShipments();

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");

            // DeliveryCenter tracking
            center.PrintTrackingStatuses();

            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            Console.WriteLine("==========================================");

            Console.WriteLine(
                "Standard Shipment Insurance : " +
                standard.CalculateInsurance().ToString("0.00") +
                " EGP");

            Console.WriteLine(
                "Express Shipment Insurance : " +
                express.CalculateInsurance().ToString("0.00") +
                " EGP");

            Console.WriteLine(
                "International Shipment Insurance : " +
                international.CalculateInsurance().ToString("0.00") +
                " EGP");

            Console.WriteLine("==========================================");

            // Interface Polymorphism - ITrackable
            ITrackable[] trackableShipments =
            {
            standard,
            express,
            international
        };

            Console.WriteLine("ITrackable Array:");

            foreach (ITrackable shipment in trackableShipments)
            {
                DeliveryReport.PrintShipment(shipment);
            }

            Console.WriteLine("------------------------------------------");

            // Interface Polymorphism - IInsurable
            IInsurable[] insurableShipments =
            {
            standard,
            express,
            international
        };

            Console.WriteLine("IInsurable Array:");

            foreach (IInsurable shipment in insurableShipments)
            {
                DeliveryReport.PrintInsurance(shipment);
            }

            Console.WriteLine("==========================================");
            Console.WriteLine(
                "Interface Polymorphism Demonstrated Successfully.");
            Console.WriteLine("==========================================");
        }

            #endregion
    }
}
