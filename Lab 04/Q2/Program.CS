using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindValues newobj2 = new FindValues();
            Console.WriteLine("Enter radius: ");
            double radius =double.Parse(Console.ReadLine());
            double area = newobj2.findArea(radius);
            double circum = newobj2.findCircumference(radius);
            Console.WriteLine("The Area:" + area );
            Console.WriteLine("The Circumference:" + circum);
        }
    }
}
