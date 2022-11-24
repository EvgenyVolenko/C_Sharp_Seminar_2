// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int numberA = new Random().Next(10, 100); 
Console.WriteLine("Случайное число из диапазона [10, 99] = " + numberA);

int lasdDigit = numberA % 10;
int firstDigit = (numberA - lasdDigit) / 10;

if (lasdDigit > firstDigit) Console.WriteLine("Наибольшая цифра в числе вторая = " + lasdDigit);
if (lasdDigit < firstDigit) Console.WriteLine("Наибольшая цифра в числе первая = " + firstDigit);