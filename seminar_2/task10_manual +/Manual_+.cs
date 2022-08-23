// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное положительное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num >= 1000) 
{
    Console.WriteLine("Некорректный ввод, введите трёхзначное положительное число.");
}
else if (num > 99 || num <= 999)
{
int num1 = num / 100;
int num2 = num / 10;
int res = num2 - num1 * 10;
Console.WriteLine($"{num} -> {res}");
}