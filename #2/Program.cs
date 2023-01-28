string[] DayOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите номер недели: ");
int a = int.Parse(Console.ReadLine());

if (a<=DayOfWeek.Length)
Console.WriteLine(DayOfWeek[a-1]);
else
Console.WriteLine("Такого дня недели нет!");