﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal sum = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        int i = 0;
        while (i < months)
        {
            sum += sum * 0.07m;
            i++;
        }

        Console.WriteLine($"Конечная сумма: {sum:F2}");
    }
}
