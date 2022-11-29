Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (max == a)
{
    if (a > c)
    {
        max = a;
    }
    
    else
    {
        max = c;
    }
}
else 
{ 
    if (b > c)
    {
        max = b;
    }
    
    else
    {
        max = c;
    }

}
Console.Write("Максимальное число: ");
Console.WriteLine(max);

