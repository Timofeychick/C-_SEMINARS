// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double [] array = new double [20];

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(-9999,9999);
    Console.Write($"{array[i]} ");
    if (array[i] > max) max = array[i];
    if (min > array[i]) min = array[i];
}
double res = max - min;

Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива равна {res}");