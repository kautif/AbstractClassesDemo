using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */
            #region Vehicles

            /*
             * X Create an abstract class called Vehicle
             * X The vehicle class shall have three string properties Year, Make, and Model
             * X Set the defaults to something generic in the Vehicle class
             * X Vehicle shall have an abstract method called DriveAbstract with no implementation
             * X Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * X Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * X Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * X Provide the implementations for the abstract methods
             * ? What implementations? How?
             * X Only in the Motorcycle class will you override the virtual drive method
            */

            // X Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             * ? How?
             */
            Car prius = new Car
            {
                HasTruck = true,
                Year = 2024,
                Make = "Toyota",
                Model = "Prius"
            };
            Motorcycle rebel = new Motorcycle { 
                HasSideCart = true,
                Year = 2019,
                Make = "Honda",
                Model = "Rebel"
            };
            Car charger = new Car
            {
                Year = 2023,
                Make = "Dodge",
                Model = "Charger"
            };
            Car focus = new Car
            {
                Year = 2018,
                Make = "Ford",
                Model = "Focus"
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(charger);
            vehicles.Add(focus);
            vehicles.Add(prius);
            vehicles.Add(rebel);

            foreach (Vehicle vehicle in vehicles) {
                Type type = vehicle.GetType();
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"{property.Name}: {property.GetValue(vehicle)}");
                }
            }

            prius.DriveAbstract();
            rebel.DriveVirtual();

            // X Call each of the drive methods for one car and one motorcycle
            prius.DriveAbstract();
            rebel.DriveVirtual();
            #endregion            
            Console.ReadLine();
        }
    }
}
