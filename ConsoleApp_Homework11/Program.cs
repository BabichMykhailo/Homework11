using ConsoleApp_Homework11;
using System;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCollection myCollection = new MyCollection();
            myCollection.Add(2);
            myCollection.Add(3);
            myCollection.Add(4);
            foreach(var i in myCollection)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
