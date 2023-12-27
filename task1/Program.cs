// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

// Вводим число
using System;
class Program
{
static void Main()
{
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

// Составляем алгаритм по кратности чисел 7 и 23
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"a = {num} => да");
}
else
{
    Console.WriteLine($"a = {num} => нет");
}
}
}