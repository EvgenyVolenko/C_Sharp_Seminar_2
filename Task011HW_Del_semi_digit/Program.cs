// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numberA = new Random().Next(100, 1000); 
Console.WriteLine("Случайное число из диапазона [100, 999] = " + numberA);

int lasdDigit = numberA % 10;
int semiDigit = numberA / 10;
int firstDigit = numberA / 100;

Console.WriteLine("Число без средней цифры = " + firstDigit + lasdDigit);