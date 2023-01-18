// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение 1

begin:

Console.Write("Введите трехзначное число: ");
string text = Console.ReadLine();

if (text.Length != 3)
{
    System.Console.WriteLine("неверный ввод");
    goto begin;
}
else
{
    System.Console.WriteLine(text[1]);
}
