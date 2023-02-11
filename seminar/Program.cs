/**Задача 0:** 

**Условие:**

Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

**Например:**

4 -> 16
-3 -> 9
-7 -> 49*/

Console.Clear();
Console.Write("Введите число 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число квадрат первого: ");
int numberB = int.Parse(Console.ReadLine());
int sqr = numberA * numberA;
    if (numberB == sqr)
        {
        Console.WriteLine("Правильно! ");
        }
        else
        {
    Console.WriteLine("Не правильно! ");
        }