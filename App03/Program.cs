using System;

namespace App03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c) { Console.WriteLine("Все числа равны!"); }
            else if (a == b || a == c)
            {
                if (b > c) { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", b, c); }
                else { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", c, b); }
            }
            else if (b == c)
            {
                if (b > a) { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", b, a); }
                else { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", a, b); }
            }
            if (a > b && a > c)
            {
                if (c > b) { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", a, b); }
                else { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", a, c); }
            }
            else if (b > a && b > c)
            {
                if (a > c) { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", b, c); }
                else { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", b, a); }
            }
            else if (c > a && c > b)
            {
                if (a > b) { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", c, b); }
                else { Console.WriteLine("{0} самое большое число, {1} самое маленькое число", c, a); }
            }
            Console.ReadLine();
        }
    }
}
