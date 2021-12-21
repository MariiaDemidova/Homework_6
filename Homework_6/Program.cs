using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строчку без знаков препинания:");
            string firstString = Console.ReadLine();
            string[] word = firstString.Split();
            int maxL = 0;
            Console.WriteLine();
            Console.WriteLine("Самое длинное слово:");
            foreach (string i in word)
            {
                if (i.Length > maxL)
                {
                    maxL = i.Length;
                }
            }
            foreach (string i in word)
            {
                if (i.Length == maxL)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
