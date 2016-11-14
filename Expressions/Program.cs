using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        public static void Main()
        {
            int x = 32;
            List<int> evenNumbers = new List<int>();
            ArrayList old = new ArrayList();
            Dictionary<int, bool> isEvenNumberDict = new Dictionary<int, bool>();

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                    old.Add(i);
                    isEvenNumberDict.Add(i, true);
                }
                else
                {
                    isEvenNumberDict.Add(i, false);
                }
            }

            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            foreach (var entry in isEvenNumberDict)
            {
                Console.WriteLine(entry.Key + " = " + entry.Value);
            }

            Console.WriteLine("First item on list: " + evenNumbers[0]);
            Console.WriteLine("Is 3 an even number? " + isEvenNumberDict[3]);

            Console.ReadKey();
        }
    }
}
