// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите любое целое число");
double num = Convert.ToDouble(Console.ReadLine());
if (num % 1 != 0)
{
    Console.WriteLine("Число должно быть целым. Попробуйте еще раз.");
}
else
{
    if (num % 2 == 0)
    {
        Console.WriteLine($"Число {num} - четное.");
    }
    else
    {
        Console.WriteLine($"Число {num} - нечетное.");
    }
}