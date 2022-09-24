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
            mailaddress.City = "Rovno";
            mailaddress.Street = "School";
            mailaddress.House = 12;
            mailaddress.Apartment = 39;

            Console.WriteLine($"Index: {mailaddress.Index} | Country: {mailaddress.Country} | City: {mailaddress.City} | Street: {mailaddress.Street} | House: {mailaddress.House} | Apartment: {mailaddress.Apartment}");
        }
    }
}