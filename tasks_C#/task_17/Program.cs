// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число 1");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1*num_1 == num_2)
{
     Console.WriteLine("Число 2 являяется квадратом числа 1");
}
else if (num_2*num_2 == num_1)
{
     Console.WriteLine("Число 1 являяется квадратом числа 2");
}
else
{
     Console.WriteLine("Ни одно из чисел не является квадратом другого");
}