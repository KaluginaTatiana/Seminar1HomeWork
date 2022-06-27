// Дано N секунд. Вывести время в формате часы:минуты:секунды.
//N = 72334 -> 20:5:34
int N = 72334;
int Hour = N / 3600;
int Min = (N % 3600) / 60;
int Sec = (N % 3600) % 60;
Console.Write(Hour);
Console.Write(":");
Console.Write(Min);
Console.Write(":");
Console.WriteLine(Sec);