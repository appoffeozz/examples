// Задача 19: Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}

//Задача 21 Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int aX, aY, aZ;
int bX, bY, bZ;
double resultDoub;

Console.WriteLine("Введите посследовательность координат: ");
Console.Write("aX: ");
    aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
    aY = Convert.ToInt32(Console.ReadLine());
Console.Write("aZ: ");
    aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("bX: ");
    bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
    bY = Convert.ToInt32(Console.ReadLine());
Console.Write("bZ: ");
    bZ = Convert.ToInt32(Console.ReadLine());

resultDoub = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
resultDoub = Math.Sqrt(resultDoub);
resultDoub = Math.Round(resultDoub, 2);
Console.WriteLine(resultDoub);

//Задача 23 Напишите программу, 
// которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num;
Console.Write("Введите любое число: ");
num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i, 3)}, ");
Console.WriteLine(" ");