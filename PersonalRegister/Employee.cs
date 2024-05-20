using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Employee
    {

        private List<(string userName, double rate)> users;

        public Employee() { 
            users = new List<(string userName, double rate)> ();
        }

        public void Add (string userName, double rate)
        {
            users.Add((userName, rate));
        }

        public void DisplayUsers() { 
            foreach (var user in users)
            {
                Console.WriteLine($"User: {user.userName}, Rate: {user.rate}");
            }
        }
    }
}
