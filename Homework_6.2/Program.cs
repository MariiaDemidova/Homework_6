using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строчку без знаков препинания:");
            string s = Console.ReadLine();
            string sWithout = s.Replace(" ", "");
            char[] reverseS = sWithout.ToCharArray();
            Array.Reverse(reverseS);
            string s2 = new string(reverseS);
            bool equal = String.Equals(sWithout, s2, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine();
            if (equal == true)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
