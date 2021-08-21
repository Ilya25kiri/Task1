
using System;
using System.Linq;
using System.Collections.Generic;



class ChangeCurrency
{
    public string IOS { get; set; }
    public double Rate { get; set; }
}

class Changer
{
    public readonly List<ChangeCurrency> currencies = new List<ChangeCurrency>()
    {
        new ChangeCurrency{ IOS = "USD", Rate = 26.71 },
        new ChangeCurrency{ IOS = "EUR", Rate = 31.45 }
    };
    public void Print()
    {
        Console.WriteLine("Availabel currencies:");
        foreach (var x in currencies.Select((value, index) => new { value, index }))
        {
            Console.WriteLine(x.value.IOS + " " + x.value.Rate);
        }
    }
}

class Adding
{
    public Adding(Changer changer)
    {
        changer = new Changer();
    }

    public void AddingRate(Changer changer)
    {
        Console.Clear();
        Console.WriteLine("Adding a new currency");
        Console.Write("\nEnter a new IOS code: ");
        string name = Console.ReadLine();
        Console.Write("\nEnter a rate of this currency: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        changer.currencies.Add(new ChangeCurrency { IOS = name, Rate = rate });
        Console.WriteLine("Press Backspece to back to the main menu");
        Console.ReadLine();
        Console.Clear();
    }
}

class Exchange
{
    public Exchange(Changer changer)
    {
        changer = new Changer();
    }

    public void ExchangeMoney(Changer changer)
    {
        foreach (var x in changer.currencies.Select((value, index) => new { value, index }))
        {
            Console.WriteLine(x.value.IOS + " " + x.value.Rate);
        }
        int num1 = 0;
        int count = 0;
        int num2 = 0;
        Console.WriteLine("Type appropriat digit to select currency:");
        Console.Write("Your chouse: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        var num1P = changer.currencies.ElementAt(num1 - 1);

        Console.WriteLine("\n Select your destination currency: \n");
        Console.Write("Your chouse: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        var num2P = changer.currencies.ElementAt(num2 - 1);

        Console.WriteLine("\n Enter your source currency Amount: ");
        count = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n Final you have: " + num2P.IOS + ": " + Math.Round(num1P.Rate * count / num2P.Rate, 4));
        Console.WriteLine("Press Backspece to back to the main menu");
        Console.ReadLine();
        Console.Clear();
    }
}

namespace ТЗ
{
    class Program
    {
        static void Main()
        {
            Changer chang = new Changer();
            for (int n = 0; n < 1;)
            {
                int result = 0;


                chang.Print();

                Console.WriteLine("\n" + "1) Exchange currency");
                Console.WriteLine("2) Add new currency");
                Console.WriteLine("3) Exit");
                Console.Write("\nYour chouse: ");
                result = Convert.ToInt32(Console.ReadLine());

                switch (result)
                {
                    case 1:
                        Exchange exchange = new Exchange(chang);
                        exchange.ExchangeMoney(chang);
                        break;
                    case 2:

                        Adding adding = new Adding(chang);
                        adding.AddingRate(chang);

                        break;

                    case 3:
                        Console.WriteLine("\n Program ended");
                        n++;
                        break;
                }
            }


        }
    }
}
