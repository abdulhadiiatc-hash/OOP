using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.IO;
using System.Reflection.Metadata;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\OOP\\test.txt";
            string[] names = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                readData(path, names, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.Write("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string p = Console.ReadLine();
                    signIn(n, p, names, password);
                }
                else if (option == 2)
                {
                    Console.Write("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter New Password: ");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }
            }
            while (option < 3);
            Console.Read();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.Write("Enter Option ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void readData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exist");
                Console.ReadKey();
            }
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for(int x = 0; x < record.Length; x++)
            { 
            
                if (record[x] == ',')
                {
                    comma++;
                }else if(comma == field){
                    item = item + record[x];
                }
            }
            return item;
        }
        static void signIn(string n, string p, string[] names, string[] passwords)
        {
            bool flag = false;
            for(int x = 0; x < 5; x++)
            {
                if(n == names[x] && p == passwords[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                    break;
                }
            }
            if(flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void signUp(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
    } 
}