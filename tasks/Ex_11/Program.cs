// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// ввод двузначного числа пользователем
Console.Write("Input number [10,99]: ");
int number = Convert.ToInt32(Console.ReadLine());
// разбивка числа путем деления с отстатком и нацело
if (number < 100 && number > 9)
{
    int a = number / 10;
    int b = number % 10;
    int max = 0;
    if (b > a)
    {
        max = b;
        Console.WriteLine($"Наибольшая цифра в числе {number} является {max}");
    }
    if (a > b)
    {
        max = a;
        Console.WriteLine($"Наибольшая цифра в числе {number} является {max}");
    }
    else if (a == b)
    {
        Console.WriteLine($"Цифры в числе {number} равны");
    }

}
else if (number > 99 || number < 10)
{
    Console.WriteLine("Введено не корректное число");
}
// сравнение данных чисел между собой

// вывод максимального числа между собой
