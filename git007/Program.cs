﻿// Задача 2Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.


int a, b; 
        Console.Write("Введите первое число: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = int.Parse(Console.ReadLine());

        if (a > b)
            Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", a, b);
            
        else Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", b, a);