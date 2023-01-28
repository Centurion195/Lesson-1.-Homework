string num = new Random().Next(100,1000).ToString();
Console.WriteLine ("Случайное трехзначное число: " + num);
string NewNum = num.Replace(num.Substring(1,1), "");
Console.WriteLine ("Удалена вторая цифра числа: " + NewNum);