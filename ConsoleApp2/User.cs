using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = DateTime.Now;
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine("Information about user");
            Console.WriteLine("Login:" + Login);
            Console.WriteLine("FirstName:" + FirstName);
            Console.WriteLine("LastName:" + LastName);
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("RegistrationDate:" + RegistrationDate);
        }
    }
}
