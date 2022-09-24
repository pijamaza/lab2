using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter exchange = new Converter();
            exchange.Usdtouah = 36.94;
            exchange.Eurotouah = 37.45;
            exchange.Rublstouah = 0.61;

            double UAH;

            exchange.Uahtousd = 0.027;
            exchange.Uahtoeuro = 0.027;
            exchange.Uahtorubls = 1.63;

            double compareSum = 0;
            string choice;
            string cycleCondition = "";


            Console.Write("В какую валюту Вы хотите конвертировать?\n" +
                "1-рубли, 2-доллары, 3-евро, 4-гривны:");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Количество гривен:");
                UAH = double.Parse(Console.ReadLine());
                Console.WriteLine(UAH + " в RUB " + UAH * exchange.Uahtorubls + "₽");
                compareSum = exchange.Rublstouah;
            }
                
            else if (choice == "2")
            {
                Console.WriteLine("Количество гривен:");
                UAH = double.Parse(Console.ReadLine());
                Console.WriteLine(UAH + " в USD " + UAH * exchange.Uahtousd + "$");
                compareSum = exchange.Usdtouah;
            }
                
            else if (choice == "3")
            {
                Console.WriteLine("Количество гривен:");
                UAH = double.Parse(Console.ReadLine());
                Console.WriteLine(UAH + " в EURO " + UAH * exchange.Uahtoeuro + "€");
                compareSum = exchange.Eurotouah;
            }
                
            else if (choice == "4")
            {
                Console.WriteLine("Это конвертация гривны в другие валюты:" +
                    "\n1-рубли, 2-доллары, 3-евро:");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Количество гривен:");
                    UAH = double.Parse(Console.ReadLine());
                    Console.WriteLine(exchange.Rublstouah * UAH + UAH + " RUB ");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Количество гривен:");
                    UAH = double.Parse(Console.ReadLine());
                    Console.WriteLine(exchange.Usdtouah * UAH + UAH + "$");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Количество гривен:");
                    UAH = double.Parse(Console.ReadLine());
                    Console.WriteLine(exchange.Eurotouah * UAH + UAH + "€");
                }
            }    
        }
    }
}
