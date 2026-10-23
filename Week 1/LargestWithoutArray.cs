using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 , num3;
            Console.WriteLine("Enter 1st Number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("1st number is largest");
            }else if(num2 > num1 && num2 > num3)
            {
                Console.WriteLine("2nd number is largest");
            }else if( num3 > num1 && num3 > num2)
            {
                Console.WriteLine("3rd number is largest");
            }
        }
    }
}
