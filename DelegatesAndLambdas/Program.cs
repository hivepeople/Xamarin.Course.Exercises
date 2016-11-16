using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambdas
{
    class User
    {
        public string Name { get; set; }
        public int AgeInYears { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var users = new LinkedList<User>();
            var hans = new User
            {
                Name = "Hans",
                AgeInYears = 30
            };
            users.AddToFront(hans);

            // If we don't use our new ToString variant, we 
            // are bound by the item types' implementation
            // of ToString
            Console.WriteLine("default: " + users.ToString());

            // With the new ToString taking a delegate, we
            // can control the string representation of
            // items for each call and without changing the
            // User class (it may be a class we cannot change)
            Console.WriteLine("custom: " + users.ToString(FormatUser));

            // Instead of writing a method each time we need
            // to provide a delegate, we can use a lambda
            // expression
            string userAges = users.ToString(u => u.AgeInYears.ToString());
            Console.WriteLine("age only: " + userAges);

            Console.ReadKey();
        }

        static string FormatUser(User user)
        {
            return user.Name + " (" + user.AgeInYears + ")";
        }
    }
}
