using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        public string name;
        public string surname;
        public string jobtitle;
        public double rate;
        public int experience;
        public double tax;

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

        public string Jobtitle
        {
            set
            {
                jobtitle = value;
            }

            get
            {
                return jobtitle;
            }
        }

        public double Rate
        {
            set
            {
                rate = value;

            }
            get
            {
                return rate;
            }
        }

        public int Experience
        {
            set
            {
                experience = value;
            }
            get
            {
                return experience;
            }
        }

        public double Tax
        {
            set
            {
                tax = value;
            }
            get
            {
                return tax;
            }
        }
        public double CalculateSalary()
        {
            return Rate * Experience * (1 - Tax);
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine("Employee's name: {0} {1}", Name, Surname);
            Console.WriteLine("Job Title: {0}", Jobtitle);
            Console.WriteLine("Salary: {0}", CalculateSalary());
        }
    }
}
