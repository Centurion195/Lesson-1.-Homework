Task1 analys = new Task1();
Console.WriteLine("Введите два числа: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
bool res = analys.Calc(a,b);
if (res==true)
    Console.WriteLine("Первое число является квадратом второго.");
    else
    Console.WriteLine("Первое число НЕ является квадратом второго.");

class Task1
    {
        public bool Calc (int x, int y)
        {
            bool result = false;
            if (x==(y*y)) result = true;
            return result;
        }
    }
