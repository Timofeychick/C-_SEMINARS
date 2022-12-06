// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int [] array = new int [20];
int resEven = 0;
int resOdd = 0;
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) 
    {
        resEven += 1;
    }
    else 
    {
        resOdd += 1;
    }
}
for (int i = 0; i < array.Length; i++) 
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($" Колличество четных чисел = {resEven}");
Console.WriteLine($" Колличество нечетных чисел = {resOdd}");