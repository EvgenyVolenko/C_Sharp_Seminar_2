// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// ​645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit < 100) Console.Write("У числа нет третьей цифры");
else 
{
    while (digit > 999)
    {
        digit = digit / 10;
    }
    int thirdDigit = digit % 10; 
    Console.WriteLine("Третья цифра = " + thirdDigit);
}