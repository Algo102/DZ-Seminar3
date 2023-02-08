Console.Clear();

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("-------------------");
Console.WriteLine("Произведение всех чисел до N");
int result = 1;
for (int i = 1; i < N+1; i++)
{
  result = result * i;
  Console.WriteLine($"{i}) {result}");
}
Console.WriteLine($"Произведенние {N} чисел равно {result}");