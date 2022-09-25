using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Vadim";
            user.surname = "Koval";
            user.age = 23;
            user.login = "kovalVD";
            user.password = "973137";
            user.registrationDate = DateTime.Now;
            
            user.ShowUserInfo();
        }
    }
}
