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
            int Num = 0;
            int Sum = 0;
            while(Num != -1)
            {
                Sum = Sum + Num;
                Console.Write("Enter a Number: ");
                Num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum is " + Sum);
        }
    }
}
