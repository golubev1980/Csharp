// Задача 13. Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int num3 = num % 10;
int count = num / 10;

while (true)
{
    if (count < 10)
    {
        Console.WriteLine($"Третья цифра (слева направо) в числе {num} отсутствует");
        break;
    }
    else if (count < 100)
    {
        Console.WriteLine($"Третья цифра (слева направо) в числе {num} равна - {num3}");
        break;
    }
    else
    {
        num3 = count % 10;
        count = count / 10;
        continue;
    }
}
