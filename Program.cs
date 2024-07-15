using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BMICalculator.models;

namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(101, "Ram", 45, 204.2, 50.0, "Person 1 Details");

            //An instance which does not have height, weight & title,
            //so the default values of these attributes would be retrived.
            Person person2 = new Person(102, "Shyam", 35);

            Console.WriteLine(person1);
            Console.WriteLine(person2);

        }
    }
}
