﻿/**Задача 0:** 

**Условие:**

Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

**Например:**

4 -> 16
-3 -> 9
-7 -> 49*/

Console.Write("Введите число от 1 до 7");
int a = int.Parse(Console.ReadLine());
if (a <= 0)Console.WriteLine("Введите число от 1 до 7");
if (a > 7)Console.WriteLine("Введите число от 1 до 7");
if (a == 1)Console.WriteLine("Понедельник");
if (a == 2)Console.WriteLine("Вторник");
if (a == 3)Console.WriteLine("Среда");
if (a == 4)Console.WriteLine("Четверг");
if (a == 5)Console.WriteLine("Пятница");
if (a == 6)Console.WriteLine("Суббота");
if (a == 7)Console.WriteLine("Воскресенье");