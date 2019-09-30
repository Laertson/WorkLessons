using System;

namespace App02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фразу:");
            string a = Console.ReadLine();
            char b = a[0];
            Console.WriteLine("{0}{1}{0}", b, a);
            Console.ReadLine();
        }
    }
}
