//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
//Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
//Пример: 
//["hello", "2", "world", ":-)"] -> ["2", ":-)"]

string[] M;
Console.WriteLine("Введите массив строк через пробел");
string firstStroka = Console.ReadLine();
M = firstStroka.Split(' ');
var result = new string[M.Length];
var realSize = 0;
foreach (var value in M)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine("Полученный массив c искомыми элементами: ");
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);