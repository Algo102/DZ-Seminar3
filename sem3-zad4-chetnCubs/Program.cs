Console.Clear();
Console.WriteLine("Четные кубы всех чисел до N");
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("-------------------");

for (int i = 1; i < N+1; i++)
{
  double cube = Math.Pow(i, 3);
  if (cube%2==0)
  Console.WriteLine($"{i}) {cube}");
}