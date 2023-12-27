// Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и
// показывает наибольшую цифру числа.

int input = new Random(). Next(10,99);
int firstNum = input / 10;
int secondNum = input % 10;
Console.Write($"Принимается число: {input}.\n");
if (firstNum > secondNum) Console.Write($"Наибольшее: {firstNum}.");
if (firstNum < secondNum) Console.Write($"Наибольшее: {secondNum}.");
if (firstNum == secondNum) Console.Write($"Числа равны.");