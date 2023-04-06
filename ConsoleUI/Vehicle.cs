using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle() { }
        public int Year { get; set; } = 2023;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Prius";

        // no implementation
        public abstract void DriveAbstract();

        // base implementation
        public virtual void DriveVirtual() {
        
        }
    }
}
