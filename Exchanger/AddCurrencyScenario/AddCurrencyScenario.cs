using System;

namespace Exchanger.AddCurrencyScenario
{
    using Exchanger.CurrencyChanger;
    using Exchanger.ChangeCurrency;
    public class AddCurrencyScenario
    {
        public AddCurrencyScenario(CurrencyChanger changer)
        {
            changer = new CurrencyChanger();
        }

        public void AddingRate(CurrencyChanger changer)
        {
            for (; ; )
            {
                double rate = 0;
                Console.Clear();
                Console.WriteLine("Adding a new currency");
                Console.Write("\nEnter a new IOS code: ");
                string name = Console.ReadLine();
                try
                {
                    Console.Write("\nEnter a rate of this currency: ");
                    rate = Convert.ToDouble(Console.ReadLine());
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

                changer.Currencies.Add(new ChangeCurrency { IOS = name, Rate = rate });
                Console.WriteLine("Press Backspece to back to the main menu");
                Console.ReadLine();
                Console.Clear();
                break;
            }
        }
    }
}
