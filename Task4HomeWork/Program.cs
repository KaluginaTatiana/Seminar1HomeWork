// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа для сравнения");
Console.WriteLine("Введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число");
double num3 = Convert.ToDouble(Console.ReadLine());
double max;
if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.Write("Максимальное число = ");
Console.Write(max);
Console.WriteLine(".");