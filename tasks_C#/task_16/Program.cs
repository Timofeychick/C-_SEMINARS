//Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите любое число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Ноль не кратен ни чему");
}
else 
{
    if (number % 7 == 0)
    {
        Console.WriteLine("Число кратно 7");
    }
    else if (number % 23 == 0)
    {
        Console.WriteLine("Число кратно 23");
    }
    else 
    {
        Console.WriteLine("Число не кратно ни одному из чисел");
    }
}