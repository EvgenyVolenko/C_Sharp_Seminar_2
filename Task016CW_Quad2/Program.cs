// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите число №1 ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2 ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit * firstDigit == secondDigit | secondDigit * secondDigit == firstDigit) Console.Write("да");
else Console.Write("нет");