using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Exchanger.CurrencyChanger
{
    using Exchanger.ChangeCurrency;
    public class CurrencyChanger
    {
        private readonly List<ChangeCurrency> currencies = new List<ChangeCurrency>()
    {
        new ChangeCurrency{ IOS = "USD", Rate = 26.71 },
        new ChangeCurrency{ IOS = "EUR", Rate = 31.45 }
    };

        internal List<ChangeCurrency> Currencies => currencies;

        public int Print(int result)
        {
            try
            {
                Console.WriteLine("Availabel currencies:");
                foreach (var x in currencies.Select((value, index) => new { value, index }))
                {
                    Console.WriteLine(x.value.IOS + " " + x.value.Rate);
                }
                Console.WriteLine("\n" + "1) Exchange currency");
                Console.WriteLine("2) Add new currency");
                Console.WriteLine("3) Exit");
                Console.Write("\nYour chouse: ");
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("There is no such item in the menu: ");
                Console.WriteLine("Press Backspece to back to the main menu");
                Console.ReadLine();
                Console.Clear();
                return 0;
            }
        }
    }
}
