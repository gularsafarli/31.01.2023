using System;
using System.Net.Http.Headers;

namespace Encapsualiton__Academy_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Student
            // Student st1 = new Student();
            //st1.Age = 14;
            //st1.Age = 43;
            //Console.WriteLine(st1.Age);
            #endregion

            #region Vehicle
            //Vehicle vhc = new Vehicle();
            //vhc.Drive(4);
            //vhc.Drive(14);
            //Console.WriteLine(vhc.Mileage);

            Car cr = new Car(60);            
            cr.FuelFor1Km = 0.3;

            cr.AddFuel(10);
            cr.AddFuel(15);
            cr.AddFuel(15);

            cr.Drive(5);
            cr.Drive(7);
            cr.Drive(15);


            Console.WriteLine("FuelCapacity:" + cr.FuelCapacity);
            Console.WriteLine("Currenfuelt:" + cr.CurrentFuel);
            Console.WriteLine("Mileage:" + cr.Mileage);

            #endregion
        }
    }
}
