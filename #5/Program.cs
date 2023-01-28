Console.WriteLine ("Введите число больше 1: ");
int NumEnd = Convert.ToInt32(Console.ReadLine());

for (int i = 1; NumEnd>=i; i++)
{
    if (i%2==0) Console.WriteLine (i);
}