using System;
using Hometask013123;

namespace Program_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            Product pr = new Product();
            pr.Name = "Edward Snowden";
            Console.WriteLine(pr.Name);

            pr.Price = -12;
            pr.Price = 12;
            Console.WriteLine(pr.Price);

            Drink dr = new Drink();
            dr.AlcoholPercent = 150;
            dr.AlcoholPercent = 0.8;
            Console.WriteLine(dr.AlcoholPercent);
            #endregion

        }
    }
}
