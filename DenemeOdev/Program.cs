using System;

namespace DenemeOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

        }
        static void Add()
        {
            Console.WriteLine("Added !!!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;

        }
    }
}
