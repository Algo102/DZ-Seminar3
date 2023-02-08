Console.Clear();

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine() ?? "0");

//Определяем количество цифр в числе
int count = 1;
int schet = N;
if (schet < 0) schet = schet * (-1);
while (schet > 9)
{
  schet =schet / 10;
  count++;
}
//Console.WriteLine("В вашем числе " + count + " цифр");
if (N < 0) N = N * (-1);
switch (count)
{
    case 1:
      Console.WriteLine("В вашем числе " + count + " цифра и ее сумма равна " + N);
      break;
    case 2: 
      int two2 = N % 10;
      int one2 = (N - two2) / 10;    
      Console.WriteLine("В вашем числе " + count + " цифры и ее сумма равна " + (one2 + two2));
      break;    
    case 3: 
      int three3 = N % 10;
      int two3 = ((N - three3) / 10) % 10;  
      int one3 = (((N - three3) / 10) - two3) / 10;
      Console.WriteLine("В вашем числе " + count + " цифры и ее сумма равна " + (one3 + two3 + three3));
      break;
    case 4: 
      int two4 = N / 100 % 10;
      int three4 = N / 10 % 10;
      int four4 = N % 10;
      int one4 = N / 1000;
      Console.WriteLine("В вашем числе " + count + " цифры и ее сумма равна " + (one4 +two4 + three4 + four4));
      break;
    case 5:
      int two5 = N / 1000 % 10;
      int three5 = N / 100 % 10;
      int four5 = N / 10 % 10;
      int five5 = N % 10;
      int one5 = N / 10000;
      Console.WriteLine("В вашем числе " + count + " цифры и ее сумма равна " + (one5 + two5 + three5 + four5 + five5));
      break;
    default:
      Console.WriteLine("Больше 5 цифр не хочу обрабатывать, решай сам");
    break;
}