using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    internal class User
    {
        public string name;
        public string surname;
        public int age;
        public string login;
        public string password;
        public DateTime registrationDate;

        public string Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }

        public int Age
        {
            set
            {
                age = value;
            }

            get
            {
                return age;
            }
        }

        public string Login
        {
            set
            {
                login = value;

            }
            get
            {
                return login;
            }
        }

        public string Password
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }

        public DateTime RegistrationDate
        {
            set
            {
                registrationDate = value;
            }
            get
            {
                return registrationDate;
            }
        }
        public void ShowUserInfo()
        {
            Console.WriteLine("\n");
            Console.WriteLine("User's name: {0} {1}", Name, Surname);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Login: {0}", Login);
            Console.WriteLine("Registration date: {0}", RegistrationDate);
        }
    }
}
