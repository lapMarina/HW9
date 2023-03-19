using System;

namespace HW9
{
    class Program
    {

        static void PrintNumber(int number) 
        {
            Console.Write($"{number} ");
            number--;
            if (number >= 1)
                PrintNumber(number);
        }

        static void FirstTask()
        {
            Console.WriteLine("Введите целое число > 0");
            var number = int.Parse(Console.ReadLine());
            PrintNumber(number);
        }

        static void SecondTask() 
        {
            Console.WriteLine("Введите целое число M, где M - нижняя граница");
            var min_value = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число N, где N - верхняя граница");
            var max_value = int.Parse(Console.ReadLine());

            var sum = 0;

            for (var i = min_value; i <= max_value; i++) 
                sum += i;

            Console.WriteLine($"Сумма чисел от {min_value} до {max_value} = {sum}");

        }

        static int Ack(int m, int n) 
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if ((m > 0) && (n == 0))
            {
                return Ack(m - 1, 1);
            }
            else if ((m > 0) && (n > 0))
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
            else
                return n + 1;
        }

        static void ThirdTask() 
        {
            Console.WriteLine("Введите целое число M");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число N");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(Ack(m, n));
        }

        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
        }
    }
}
