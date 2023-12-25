using System;

namespace Work5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Ozan Alyörük");
            dictionary.Add(2, "Gizem Alyörük");

            for (int i = 0; i < dictionary.Length; i++)
            {
                Console.WriteLine(dictionary._Keys[i] + " " + dictionary._Values[i]);

            }
        }
    }
}
