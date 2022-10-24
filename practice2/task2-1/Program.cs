// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

int num = new Random().Next(100, 1000);
int two_digit = num % 100;
int one_digit = two_digit / 10;

Console.WriteLine($"Вторая цифра в числе {num} равна - {one_digit}");
