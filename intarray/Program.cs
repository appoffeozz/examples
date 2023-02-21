// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
   
int num;
Console.Write("Введите трёхзначное число: ");
num = Convert.ToInt32(Console.ReadLine());
for (int ii = 1; ii < 3 && (num <= 100 | num > 999); ii++)
{
Console.Write(ii + "попробуйте ещё раз: ");
num = Convert.ToInt32(Console.ReadLine());
}
num = num / 10 % 10;
Console.WriteLine($"Вторая цифра введённого числа: {num}");

// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
        {
    Console.Write("Третьей цифры нет: ");
        }
    else
        {
        int c = 1;
    for (int i = b; i > 3; i--)
    {
        c = c * 10;
    }
result = (a / c) % 10;
    }
return result;
}
// Задача 15: Напишите программу, которая принимает на вход цифру, 
  //обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели  "); 
int num = int.Parse(Console.ReadLine()); 
if (num >= 1 && num <= 5) 
{ 
    Console.Write(" Нет, не выходной"); 
} 
    else if (num >= 6 && num <= 7) 
{ 
    Console.Write(" Да, выходной"); 
} 
    else Console.Write(" Нет существует такого дня недели");
 //