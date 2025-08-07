using System;
using System;
using System.Diagnostics;
using System.IO.Pipelines;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins: ");
            string totalAsString = Console.ReadLine();

            double totalAsDouble = Math.Floor(Convert.ToDouble(totalAsString));
            Console.WriteLine($"{totalAsDouble} cents is equal to...");

            
            int goldValue = 10;
            int silverValue = 5;
            double goldCoins = Math.Floor((totalAsDouble / goldValue));
            double remainder = (totalAsDouble % goldValue);
            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;
            Console.WriteLine("Gold coins : " + goldCoins);
            Console.WriteLine("Silver coins : " + silverCoins);
            Console.WriteLine("Bronze coins : " + (int)remainder);



        }
    }
}
