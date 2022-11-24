// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Решил сделать с проверкой трехзначности числа

int digit;
Console.Clear();

while (true)
{
    Console.Write("Введите трехзначное число: ");
    digit = Convert.ToInt32(Console.ReadLine());
    if (digit > 99 && digit < 1000) break;
    else Console.WriteLine("Вы ввели не ту цифру");
}

int semiDigit = (digit / 10) % 10;

Console.WriteLine("Вторая цифра = " + semiDigit);