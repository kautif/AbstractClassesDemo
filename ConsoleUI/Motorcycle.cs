using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is Driving");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Driving my virtual motorcycle");
            base.DriveVirtual();
        }
        public bool HasSideCart { get; set; }
    }
}
