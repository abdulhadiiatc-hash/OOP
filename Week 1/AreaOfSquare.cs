using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.Write("Enter the length of the square: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Area = ");
            Console.WriteLine(length*length);
        }
    }
}
