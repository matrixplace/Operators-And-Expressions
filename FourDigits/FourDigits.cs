using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int fourthDigit = number % 10;
            number /= 10;

            int thirdDigit = number % 10;
            number /= 10;

            int secondDigit = number % 10;
            number /= 10;

            int firstDigit = number % 10;

            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;

            Console.WriteLine(sum);

            //dcba
            Console.WriteLine(fourthDigit + "" + thirdDigit + "" + secondDigit + "" + firstDigit);
            //dabc
            Console.WriteLine(fourthDigit + "" + firstDigit + "" + secondDigit + "" + thirdDigit);
            //acbd
            Console.WriteLine(firstDigit + "" + thirdDigit + "" + secondDigit + "" + fourthDigit);
            
        }
    }
}
