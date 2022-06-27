// Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.
Console.WriteLine("Введите два неравных числа");
Console.WriteLine("Введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());
double maxnum, minnum, div;
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
    div = (maxnum - maxnum % minnum) / minnum;
    Console.WriteLine($"Число {minnum} помещается в числе {maxnum} - {div} раз(а).");
}
else
{
    Console.WriteLine("Числа должны быть неравные. Попробуйте еще раз.");
}