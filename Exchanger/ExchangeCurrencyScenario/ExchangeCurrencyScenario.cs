using System;
using System.Linq;

namespace Exchanger.ExchangeCurrencyScenario
{
    using Exchanger.CurrencyChanger;
    class ExchangeCurrencyScenario
    {
        public ExchangeCurrencyScenario(CurrencyChanger changer)
        {
            changer = new CurrencyChanger();
        }

        public void ExchangeMoney(CurrencyChanger changer)
        {
            for (int i = 0; i < 1;)
            {
                Console.Clear();
                foreach (var x in changer.Currencies.Select((value, index) => new { value, index }))
                {
                    Console.WriteLine(x.value.IOS + " " + x.value.Rate);
                }
                int num1 = 0;
                int count = 0;
                int num2 = 0;

                try
                {
                    Console.WriteLine("Type appropriat digit to select currency:");
                    Console.Write("Your chouse: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Your answer is not correct. Please, try again: ");
                    Console.WriteLine("Press Backspece to back to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                if ((num1 - 1) >= changer.Currencies.Count)
                {
                    Console.Clear();
                    Console.WriteLine("Your answer is not correct. Please, try again: ");
                    Console.WriteLine("Press Backspece to back to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                var num1P = changer.Currencies.ElementAt(num1 - 1);



                try
                {
                    Console.WriteLine("\n Select your destination currency: \n");
                    Console.Write("Your chouse: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Your answer is not correct. Please, try again: ");
                    Console.WriteLine("Press Backspece to back to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                }
                if ((num2 - 1) >= changer.Currencies.Count)
                {
                    Console.Clear();
                    Console.WriteLine("Your answer is not correct. Please, try again: ");
                    Console.WriteLine("Press Backspece to back to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                var num2P = changer.Currencies.ElementAt(num2 - 1);


                try
                {
                    Console.WriteLine("\n Enter your source currency Amount: ");
                    count = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Your answer is not correct. Please, try again: ");
                    Console.WriteLine("Press Backspece to back to the main menu");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                i++;
                Console.WriteLine("\n Final you have: " + num2P.IOS + ": " + Math.Round(num1P.Rate * count / num2P.Rate, 4));
                Console.WriteLine("Press Backspece to back to the main menu");
                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}
