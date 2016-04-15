using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());

            while (number > 100) 
            {
                Console.WriteLine("Invalid number");
            }
           
            bool prime = true;

            if (number < 2)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number%i == 0) prime = false;
                }
            }

            Console.WriteLine(prime.ToString().ToLower());


                
            
        }
    }
}
