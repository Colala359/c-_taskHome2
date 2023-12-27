// Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

//Запросим ввод координат X и Y
using System;
class Program
{
static void Main()
{
Console.Write("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

// Создадим цикл по четвертям:
if (X > 0 && Y > 0) Console.Write($"{X}, {Y} => 1");
if (X < 0 && Y > 0) Console.Write($"{X}, {Y} => 2");
if (X < 0 && Y < 0) Console.Write($"{X}, {Y} => 3");
if (X > 0 && Y < 0) Console.Write($"{X}, {Y} => 4");
}
}