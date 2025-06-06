using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор");

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nВыберите операцию:");
        Console.WriteLine(" +  (сложение)");
        Console.WriteLine(" -  (вычитание)");
        Console.WriteLine(" *  (умножение)");
        Console.WriteLine(" /  (деление)");
        Console.WriteLine(" %  (остаток от деления)");
        Console.WriteLine(" ++ (инкремент первого числа)");
        Console.WriteLine(" -- (декремент первого числа)");

        Console.Write("\nВведите операцию: ");
        string operation = Console.ReadLine();

        double result;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Результат: {result}");
                break;

            case "-":
                result = num1 - num2;
                Console.WriteLine($"Результат: {result}");
                break;

            case "*":
                result = num1 * num2;
                Console.WriteLine($"Результат: {result}");
                break;

            case "/":
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                }
                break;

            case "%":
                if (num2 != 0)
                {
                    result = num1 % num2;
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                }
                break;

            case "++":
                result = num1 + 1;
                Console.WriteLine($"Инкремент первого числа: {result}");
                break;

            case "--":
                result = num1 - 1;
                Console.WriteLine($"Декремент первого числа: {result}");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестная операция.");
                break;
        }
    }
}