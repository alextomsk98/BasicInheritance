using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Interitance*****\n");
            MiniVan myVan = new MiniVan();

            myVan.Speed = 10;
            Console.WriteLine("My van is going{0} MPH", myVan.Speed);
            myVan.currSpeed = 55;
            Console.ReadLine();
        }
    }
}
