// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Работает и на числах с десятичной дробью, на отрицательные числа или числа менее 1 - выдает флажок с сообщениями.
Console.WriteLine("Введите число большее или равное единице ");
double num = Convert.ToDouble(Console.ReadLine());
int test; 
if (num >= 2)
{
    test = 2;
    while (test <= num)
    {
        if (test % 2 == 0)
        {
            Console.Write(" ");
            Console.Write(test);
            Console.Write(",");
        }
        test = test + 1;
    }
    Console.Write("\b");
    Console.WriteLine(".");
}
if (num < 1)
{
    Console.WriteLine("Число должно быть больше или равно единице. Попробуйте еще раз.");
}
if (num < 2)
{
    if (num >= 1)
    {
        Console.Write("Четных чисел в диапазоне от 1 до ");
        Console.Write(num);
        Console.WriteLine(" нет.");
    }
}