// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

while(true)
{
    Console.Write("Введите номер дня недели (1...7): ");
    int num = int.Parse(Console.ReadLine()!);
    if (num > 5 && num < 8)
    {
        Console.WriteLine("Этот день недели является выходным");
        break;
    }
    else if (num > 0 && num < 6)
    {
        Console.WriteLine("Этот день недели не является выходным");
        break;
    }
    else continue;
}
