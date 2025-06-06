using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

1) 
public static int SumList(List<int> numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}
2) 
public static bool IsPalindrome(string input)
{
    string cleaned = input.ToLower().Replace(" ", "");
    char[] reversed = cleaned.ToCharArray();
    Array.Reverse(reversed);
    return cleaned == new string(reversed);
}
3)

public static long Factorial(int n)
{
    if (n < 0)
        throw new ArgumentException("Факториал не определён для отрицательных чисел.");

    long result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}
4) 
public static int FindMax(List<int> numbers)
{
    if (numbers == null || numbers.Count == 0)
        throw new ArgumentException("Список пуст.");

    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (number > max)
            max = number;
    }
    return max;
}
5) 

public static List<int> RemoveDuplicates(List<int> numbers)
{
    return numbers.Distinct().ToList();
}