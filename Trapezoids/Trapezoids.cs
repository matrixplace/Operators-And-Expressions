using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {

            Console.Write("Enter 'a': ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter 'b': ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter 'h': ");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("{0:0.0000000}",area);
        }
    }
}
