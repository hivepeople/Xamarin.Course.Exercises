using System;

namespace Generics
{
    class User
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var names = new LinkedList<string>();

            names.AddToFront("Jens");
            names.AddToFront("Anders");
            names.AddToFront("Hans");

            Console.WriteLine(names.ToString());

            var users = new LinkedList<User>();

            users.AddToFront(new User { Name = "Hans" });
            Console.WriteLine(users.ToString());

            LinkedList<object> listOfObjects = new LinkedList<object>();
            LinkedList<LinkedList<object>> listOfLists = new LinkedList<LinkedList<object>>();
            //listOfLists.AddToFront(names);  <- compile error
            //listOfLists.AddToFront(users);  <- compile error
            listOfLists.AddToFront(listOfObjects);  // allowed

            Console.ReadKey();
        }
    }
}
