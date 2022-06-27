// На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.
Console.WriteLine("Введите рост трех спортсменов в саниметрах");
Console.WriteLine("Введите рост первого спортсмена");
double height1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите рост второго спортсмена");
double height2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите рост третьего спортсмена");
double height3 = Convert.ToDouble(Console.ReadLine());
double place1, place2, place3;
if (height1 > height2)
{
    place1 = height1;
    place2 = height2;
}
else
{
    place1 = height2;
    place2 = height1;
}
if (height3 > place1)
{
    place3 = place2;
    place2 = place1;
    place1 = height3;
}
else
{
    if (height3 > place2)
    {
        place3 = place2;
        place2 = height3;
    }
    else
    {
        place3 = height3;
    }
}
Console.Write("Рост спортсменов в порядке убывания: ");
Console.Write(place1);
Console.Write(", ");
Console.Write(place2);
Console.Write(", ");
Console.Write(place3);
Console.WriteLine(".");