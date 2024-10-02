using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Факториал");
            Console.WriteLine("6. Корень");
            Console.WriteLine("7. Возведение в степень");
            Console.WriteLine("8. Выход\n");

            while (true)
            {
                Console.Write("Выберите действие: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        double num1 = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double num2 = double.Parse(Console.ReadLine());

                        double result = num1 + num2;

                        Console.WriteLine($"{num1} + {num2} = {result} \n\n");
                        break;

                     case 2:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());

                        result = num1 - num2;

                        Console.WriteLine($"{num1} - {num2} = {result} \n\n");
                        break;

                    case 3:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());

                        result = num1 * num2;

                        Console.WriteLine($"{num1} * {num2} = {result} \n\n");
                        break;

                    case 4:
                        Console.Write("Введите первое число: ");
                        num1 = double.Parse(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        num2 = double.Parse(Console.ReadLine());

                        result = Devide(num1, num2);

                        Console.WriteLine($"{num1} / {num2} = {result} \n\n");
                        break;

                    case 5:
                        Console.Write("Введите число: ");
                        num1 = int.Parse(Console.ReadLine());

                        result = Factorial(num1);

                        Console.WriteLine($"{num1}! = {result} \n\n");
                        break;

                    case 6:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());

                        result = SqrtNum(num1);

                        Console.WriteLine($"√{num1} = {result} \n\n");
                        break;

                    case 7:
                        Console.Write("Введите число: ");
                        num1 = double.Parse(Console.ReadLine());

                        Console.Write("Введите степень: ");
                        num2 = double.Parse(Console.ReadLine());

                        result = Math.Pow(num1, num2);

                        Console.WriteLine($"{num1}^{num2} = {result} \n\n");
                        break;

                    case 8:
                        Console.WriteLine("Спасибо за использование калькулятора. Для выхода нажмите любую клавишу");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static double Devide(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка! Деление на ноль");
            }

            return num1 / num2;
        }

        static double Factorial(double num1)
        {
            double factorial = 1;
            if (num1 == 0)
            {
                return 1;
            }

            while (num1 > 0)
            {
                factorial = factorial * num1;
                num1 -= 1;
            }

            return factorial;
        }

        static double SqrtNum(double num1)
        {
            if(num1 < 0)
            {
                Console.WriteLine("Ошибка! Подкоренное выражение меньше нуля!");
            }

            return Math.Sqrt(num1);
        }
    }
}
