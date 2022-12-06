//array[0] = 12; // присвоим элементу массива с индексом 0 - значение 12 
//Console.WriteLine(array[0]); //вывести значение массива с индексом 0 с 61 на 12

int Max(int arg1, int arg2, int arg3) // int - тип возвращаемый аргумент (в данном случае целое число), Max - имя функции, далее в скобках int - тип аргумента (целое число) и имя аргумента arg1, arg2, arg3
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} //            0    1  2   3   4   5   6   7   8 
int [] array = {61, 27, 3, 44, 15, 344, 47, 28, 9}; // int  - функция целого числа, [] - обозначени массива array - ваше имя функции может быть любое, {1....4} - сам массив


int result = Max( //упрощенный вариант - более сжатый 
    Max(array[0] , array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );
Console.Write("Максимальное число массива: ");
Console.WriteLine(result); // вывести максимальное число