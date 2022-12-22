public class MyLibrary
{


    /// <summary>
    /// Создание массива в интервале -100 до 100
    /// </summary>
    /// <param name="collect"> Имя массива </param>
    static public void FillArrayRandom(int[] collect)
    {
        int index = 0;
        int count = collect.Length;
        while (index < count)
        {
            collect[index] = new Random().Next(-100, 100);
            index++;
        }
    }
    /// <summary>
    /// Метод Вывод массива в консоль
    /// </summary>
    /// <param name="col"></param>
    static public void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        {
            Console.Write($"{col[position]} ");
            position++;
        }
    }
    /// <summary>
    /// Поиск на совпадение  в позиции
    /// </summary>
    /// <param name="collect"></param>
    /// <param name="find"></param>
    /// <returns></returns>
    static public int IndexPosition(int[] collect, int find)
    {
        int count = collect.Length;
        int index = 0;
        int position = -1;
        while (index < count)
        {
            if (collect[index] == find)
            {
                position = index;
            }
            index++;
        }
        return position;
    }
}