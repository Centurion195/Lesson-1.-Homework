string num = new Random().Next(10, 100).ToString();

string max = null;

if (Convert.ToInt32(num.Substring(0,1))>Convert.ToInt32(num.Substring(1,1)))
max = num.Substring(0,1);
else
max = num.Substring(1,1);

Console.WriteLine ("Случайное число: " + num);
Console.WriteLine ("Наибольшая цифра числа: " + max);