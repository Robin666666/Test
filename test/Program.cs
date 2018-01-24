using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "hello world";
            string test2 = test + "!!!";
            string test3 = test2 + "...";
            string test4 = test3 + ",,,";
            string test5 = test4 + "eee";
            Console.WriteLine(test5);
        }
    }
}
