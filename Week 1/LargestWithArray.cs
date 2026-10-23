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
            int[] value = new int[3];
            int largest = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                value[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                if (value[i] > largest)
                {
                    largest = value[i];
                }
            }
            Console.WriteLine("Largest number is " + largest);
        }
    }
}
