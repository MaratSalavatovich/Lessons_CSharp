//сложение двух чисел
int numberA = new Random().Next(1, 10);  //Случайное число от 1 до 9 [1,10)
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = (numberA+numberB);
Console.WriteLine(result);