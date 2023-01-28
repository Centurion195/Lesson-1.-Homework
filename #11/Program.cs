Console.WriteLine ("Введите число: ");
string num = Console.ReadLine();

if (num.Length>2)
Console.WriteLine ("Третья цифра числа: "+ num.Substring(2,1));
else
Console.WriteLine ("Нет третьей цифры числа!");