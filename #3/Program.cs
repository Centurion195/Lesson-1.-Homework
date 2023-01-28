int[] numbers = new int[3];
Console.WriteLine ("Введите 3 числа: ");

for (int i = 0; i<numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int max = numbers[0];

for (int i = 0; i<numbers.Length; i++)
{
    if (numbers[i]>max) max = numbers[i];
}

Console.WriteLine ("Максимальное число: " + max);