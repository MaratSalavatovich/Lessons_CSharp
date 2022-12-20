// 3. По заданному номеру дня недели вывести его название

Console.Write("Введите день недели: ");
int dayNumber = int.Parse(Console.ReadLine());
if (dayNumber == 1)
    Console.WriteLine("Сегодня понедельник");
if (dayNumber == 2)
    Console.WriteLine("Сегодня вторник");
if (dayNumber == 3)
    Console.WriteLine("Сегодня среда.");
if (dayNumber == 4)
    Console.WriteLine("Сегодня черверг.");
if (dayNumber == 5)
    Console.WriteLine("Сегодня пятница.");
if (dayNumber == 6)
    Console.WriteLine("Сегодня суббота.");
if (dayNumber == 7)
    Console.WriteLine("Сегодня воскресенье.");
else if (dayNumber < 1 || dayNumber > 7)
    Console.WriteLine(" Введено не корректное число ");