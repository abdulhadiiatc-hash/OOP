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
            int marks;
            Console.Write("Enter your marks: ");
            marks = int.Parse(Console.ReadLine());
            if(marks > 50)
            {
                Console.WriteLine("You are Passed");
            }else if (marks <= 50)
            {
                Console.WriteLine("You are Failed");
            }
        }
    }
}
