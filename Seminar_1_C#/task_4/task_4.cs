Console.WriteLine("Введите ваше число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int c = 0;
if (a % 2 == 0)
{
    c = a / b;
    c = c + 1;
    while (c < a + 1)
    {
        Console.Write(c);
        Console.Write(", ");
        c = c + 2;
    }
}
else
{
    c = a / b;
    c = c + 1;
    while (c < a)
    {
        Console.Write(c);
        Console.Write(", ");
        c = c + 2;
    }
}