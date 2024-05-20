using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee register = new Employee();

            while (true)
            {
                Console.WriteLine("Enter name, exit to finish");
                string name = Console.ReadLine();
                if (name == "exit")
                {
                    break;
                }
                Console.WriteLine("Enter rate");
                double rate = double.Parse(Console.ReadLine());
                register.Add(name, rate);

            }
            register.DisplayUsers();
            Console.ReadLine();


        }
    }
}
