using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> city = new List<string>();
            city.Add("Ankara");
            city.Add("Ankara");
            city.Add("Ankara");
            city.Add("Ankara");
            Console.WriteLine(city.Count);


            MyList<string> city1 = new MyList<string>();
            city1.Add("Ankara");
            city1.Add("Ankara");
            Console.WriteLine(city1.Count);

        }
    }
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Count
        {
            get { return items.Length; }
            
        }


    }

}

