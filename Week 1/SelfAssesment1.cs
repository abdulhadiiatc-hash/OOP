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
            int Age, PriceOfToy, MoneyReceived = 10, WashingMachineCost, TotalMoneySaved,MoneyLeft;
            Console.Write("Enter age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter washing machine cost: ");
            WashingMachineCost = int.Parse(Console.ReadLine());
            Console.Write("Enter price of toy: ");
            PriceOfToy = int.Parse(Console.ReadLine());
            for (int i = 0; i < Age; i++)
            {
                if (i % 2 == 0)
                {
                    MoneyReceived = MoneyReceived + 10 - 1;
                } else if (i % 2 == 1)
                {
                    PriceOfToy += PriceOfToy;
                }
            }
            TotalMoneySaved = MoneyReceived + PriceOfToy;
            if (TotalMoneySaved > WashingMachineCost)
            {
                MoneyLeft = TotalMoneySaved - WashingMachineCost;
                Console.WriteLine("The saved amount is sufficient to buy the washing machine. Money Left = " +MoneyLeft);
            }
            else
            {
                MoneyLeft = WashingMachineCost - TotalMoneySaved;
                Console.WriteLine("The saved amount is not sufficient to buy the washing machine. Money Needed = "+MoneyLeft);
            }
        }
    }
}
