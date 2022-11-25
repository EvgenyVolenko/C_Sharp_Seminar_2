// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// ​645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int mod = Math.Abs(digit);

if (mod < 100) Console.Write("У числа нет третьей цифры");
else 
{
    while (mod > 999)
    {
        mod = mod / 10;
    }
    int thirdDigit = mod % 10; 
    Console.WriteLine("Третья цифра = " + thirdDigit);
}