//4. Найти максимальное из трех чисел

//ввод чисел пользователем
Console.Write("Введите число №1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число №2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число №3: ");
int number3 = int.Parse(Console.ReadLine());
// метод сравнения чисел
int max = number1;
if (max < number2) max = number2;
if (max < number3) max = number3;
// вывод в консоль
Console.WriteLine($"Максимальное число: {max}");

