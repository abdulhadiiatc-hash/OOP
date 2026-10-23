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
            int a,b;
            Console.Write("Enter 1st Number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2st Number: ");
            b = int.Parse(Console.ReadLine());
            int result = addition(a,b);
            Console.WriteLine("Result of addition: "+result);
        }
        static int addition(int a , int b)
        {
            return a + b;
        }
    }
}
