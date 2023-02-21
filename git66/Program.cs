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