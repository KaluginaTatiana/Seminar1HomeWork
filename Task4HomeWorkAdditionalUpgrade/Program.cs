// Перевод времени в секундах в формат часы:минуты:секунды.
//72334 сек -> 20:5:34
Console.WriteLine("Введите время в секундах");
int N = Convert.ToInt32(Console.ReadLine());
int Hour = N / 3600;
int Min = (N % 3600) / 60;
int Sec = (N % 3600) % 60;
Console.Write(Hour);
Console.Write(":");
Console.Write(Min);
Console.Write(":");
Console.WriteLine(Sec);