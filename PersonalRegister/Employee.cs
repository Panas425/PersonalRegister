using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Employee
    {

        private List<(string name, double rate)> users;

        public Employee() { 
            users = new List<(string name, double rate)> ();
        }

        public void Add (string name, double rate)
        {
            users.Add((name, rate));
        }

        public void DisplayUsers() { 
            foreach (var user in users)
            {
                Console.WriteLine($"User: {user.name}, Rate: {user.rate}");
            }
        }
    }
}
