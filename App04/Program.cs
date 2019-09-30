using System;

namespace App04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру:");
            int t = Convert.ToInt32(Console.ReadLine());

            if (t < -10)
            {
                Console.WriteLine("В такую погоду хороший хозяин и собаку не выгонет.");
            }
            else if (t <= 0)
            {
                Console.WriteLine("Вода замёрзла, пан!");
            }
            else if (t <= 10)
            {
                Console.WriteLine("Жаркое северное лето.");
            }
            else if (t <= 20)
            {
                Console.WriteLine("Привет, Питер!");
            }
            else if (t <= 30)
            {
                Console.WriteLine("Хорошая погода.");
            }
            else if (t <= 40)
            {
                Console.WriteLine("Мы плавимся");
            }
            else if (t > 40)
            {
                Console.WriteLine("Адовое пекло.");
            }
            Console.ReadLine();
        }
    }
}
