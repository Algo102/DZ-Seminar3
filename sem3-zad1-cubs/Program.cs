Console.Clear();

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("-------------------");
Console.WriteLine("Ищем все кубы");
for (int i = 1; i < N+1; i++)
{
double cube = Math.Pow(i, 3);
Console.WriteLine($"Куб числа {i} = {cube}");
}