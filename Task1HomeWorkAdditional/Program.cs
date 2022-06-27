// Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран
// Если пользователь вводит не целое или отрицательное число - выводится сообщение с ошибкой.
Console.WriteLine("Введите целое число больше нуля");
double num = Convert.ToDouble(Console.ReadLine());
if (num % 1 == 0)
{
    if (num > 0)
    {
        while (num > 1)
        {
            Console.Write("1, ");
            num = num - 1;
        }
        Console.WriteLine("1.");
    }
    else
    {
        Console.WriteLine("Число должно быть больше нуля. Попробуйте еще раз.");
    }
}
else
{
    Console.WriteLine("Число должно быть целым. Попробуйте еще раз.");
}