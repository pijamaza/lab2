using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address mailaddress = new Address();
            mailaddress.Index = 33004;
            mailaddress.Country = "Ukraine";
            mailaddress.City = "Rivne";
            mailaddress.Street = "Yvileyna";
            mailaddress.House = 10;
            mailaddress.Apartment = 39;

            Console.WriteLine($"Index: {mailaddress.Index}");
            Console.WriteLine($"Country: {mailaddress.Country}");
            Console.WriteLine($"City: {mailaddress.City}");
            Console.WriteLine($"Street: {mailaddress.Street}");
            Console.WriteLine($"House: {mailaddress.House}");
            Console.WriteLine($"Apartment: {mailaddress.Apartment}");
        }
    }
}