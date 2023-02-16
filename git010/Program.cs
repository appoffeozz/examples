// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


int a, b; 
    Console.Write("Введите первое число: ");
    a = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    b = int.Parse(Console.ReadLine());

    if (a > b)
        Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", a, b);
            
    else Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", b, a);

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + thirdNumber);
    }
}

else if (secondNumber > thirdNumber)
{
    Console.WriteLine("Максимальное число: " + secondNumber);
}
else
{
    Console.WriteLine("Максимальное число: " + thirdNumber);
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a;
    Console.Write("Введите число ");
    a = int.Parse(Console.ReadLine());

    if(a % 2 == 0 )
{
    Console.WriteLine("Число четное" );
}

    else
{
    Console.WriteLine("Число нечетное" );  
}

// Задача 8  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);

