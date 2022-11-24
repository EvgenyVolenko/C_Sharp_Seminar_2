// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// ​6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int nDay;

while (true)
{
    Console.Write("Введите порядковый номер дня недели от 1 до 7: ");
    nDay = Convert.ToInt32(Console.ReadLine());
    if (nDay > 0 && nDay < 6)
    {
        Console.WriteLine("Будний день");
        break;
    }
    if (nDay > 5 && nDay < 8)
    {
        Console.WriteLine("Выходной день");
        break;
    }
    Console.WriteLine("Вы ввели недопустимое число");
}