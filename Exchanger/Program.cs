
using System;

using Exchanger.CurrencyChanger;
using Exchanger.AddCurrencyScenario;
using Exchanger.ExchangeCurrencyScenario;

namespace ТЗ
{
    class Program
    {
        
        static void Main()
        {
            CurrencyChanger chang = new CurrencyChanger();
            for (int n = 0; n < 1;)
            {
                int result = 0;
                result = chang.Print(result);
                switch (result)
                {
                    case 1:
                        ExchangeCurrencyScenario exchange = new ExchangeCurrencyScenario(chang);
                        exchange.ExchangeMoney(chang);
                        break;
                    case 2:

                        AddCurrencyScenario adding = new AddCurrencyScenario(chang);
                        adding.AddingRate(chang);

                        break;

                    case 3:
                        Console.WriteLine("\n Program ended");
                        n++;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("There is no such item in the menu: ");
                        Console.WriteLine("Press Backspece to back to the main menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }


        }
    }
}