// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Добавила еще про равенство чисел.
Console.WriteLine("Введите два числа");
Console.WriteLine("Введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
double maxnum, minnum;
if (num1 != num2)
{
    if (num1 > num2)
    {
        maxnum = num1;
        minnum = num2;
    }
    else
    {
        maxnum = num2;
        minnum = num1;
    }
    Console.Write("Большее число = ");
    Console.Write(maxnum);
    Console.Write(". ");
    Console.Write("Меньшее число = ");
    Console.Write(minnum);
    Console.WriteLine(".");
    }
else
{
    Console.WriteLine("Числа равны.");
}
