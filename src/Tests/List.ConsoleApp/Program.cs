using MyCollection;
using System;
using System.Collections.Generic;

namespace List.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>(new List<int>()
            {
                1, 2, 3, 4, 5
            });

            var result = myList.Any(x => x == 42);
            Console.WriteLine(result);
        }
    }
}
