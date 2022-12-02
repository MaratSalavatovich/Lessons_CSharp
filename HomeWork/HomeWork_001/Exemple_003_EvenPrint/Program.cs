// Задача 3: Напишите программу, которая 
//на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите натуральное число :"); 
int N = Convert.ToInt32(Console.ReadLine()); 
if (N >= 2) {
  for (int i = 2; i <= N; i +=2) 
  {
      Console.WriteLine(i);
  }
}
else 
{
    Console.WriteLine("N < 2");
};

