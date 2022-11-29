//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Напишите номер дня недели (1 - пнд, 2 - вт...)");
int number = Convert.ToInt32(Console.ReadLine());
if (0 < number && number < 8)
{
    if (number < 8 && number > 5)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else
{
    Console.WriteLine("Нет такого дня");
}