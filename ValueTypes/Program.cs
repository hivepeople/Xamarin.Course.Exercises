using System;

namespace ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumberClass classVal = new MyNumberClass();
            classVal.value = 3;

            MyNumberStruct structVal = new MyNumberStruct();
            structVal.value = 3;

            AddTo(classVal, 1);
            AddTo(structVal, 1);

            Console.WriteLine("AddTo class = " + classVal);
            Console.WriteLine("AddTo struct = " + structVal);
            Console.ReadKey();
        }

        static void AddTo(MyNumberClass x, int y)
        {
            x.value += y;
        }

        static void AddTo(MyNumberStruct x, int y)
        {
            x.value += y;
        }
    }

    public class MyNumberClass
    {
        public int value;

        public override string ToString()
        {
            return value.ToString();
        }
    }

    public struct MyNumberStruct
    {
        public int value;

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
