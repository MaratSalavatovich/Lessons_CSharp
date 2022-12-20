//2. Даны два числа. Показать большее и меньшее число
int number1 = 1;
int number2 = 2;
int max = number1;
if (max < number2) max = number2;
Console.WriteLine($"Масимальное число: {max}");