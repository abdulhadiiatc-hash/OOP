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
            string input;
            int number;
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            Console.WriteLine(number);
            Console.Read();
        }
    }
}