// В данной программе будем использовать оператор If / Else 

Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "наташа")
{
    Console.WriteLine("Ура! Это же Наташа!");
}
else
    if(username.ToLower() == "марат")
{
    Console.WriteLine("Ура! Это же Марат!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);   
}