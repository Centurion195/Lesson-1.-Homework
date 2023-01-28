Console.WriteLine ("Введите трехзначное число: ");
string a = Console.ReadLine();

if (a.Length == 3)
{
    string num3 = a.Substring(1,1);
    Console.WriteLine ("Вторая цифра числа: " + num3);
}
else
{
    Console.WriteLine ("Введено не трехзначное число!");
}