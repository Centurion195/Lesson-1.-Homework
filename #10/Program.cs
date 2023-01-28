Console.WriteLine ("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1%num2==0)
Console.WriteLine ("Первое число кратно второму.");
else
Console.WriteLine ("Первое число не кратно второму. Остаток: " + num1%num2);