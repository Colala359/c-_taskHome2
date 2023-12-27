// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

using System;
class Program
{
static void Main()
{
int input = new Random(). Next(1, 100000);
Console.Write($"Задано число: {input}.\n");
string N = Convert.ToString(input);
for (int i = 0; i < N.Length; i++)
{
    if (i == 0)
    {
        Console.Write($"Через запятую: {N[i]}");
    }
    else
    {
        Console.Write($"{N[i]}");
    }
    if (i == N.Length - 1) 
    {
        Console.Write(".");
    }
    else
    {
        Console.Write(", ");
    }
}
}
}