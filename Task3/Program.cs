using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee info = new Employee();
            info.name = "Franklin";
            info.surname = "Dils";
            info.jobtitle = "Developer";
            info.rate = 1115;
            info.experience = 5;
            info.tax = 0.2;

            info.ShowEmployeeInfo();
        }
    }
}
