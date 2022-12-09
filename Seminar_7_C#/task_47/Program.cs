// 48. Показать двумерный массив размером m×n заполненный вещественными числами
Console.Write("введите количество cтрок:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


double [,] array1 = new double [m, n];

int indexCol = 0;
int indexRow = 0;

for (int i = 0; i < m; i++) // задаем массив вещественных чисел от 0 до 1
{
    for (int j = 0; j < n; j++)
    {
        array1 [indexRow, indexCol] = new Random().NextDouble();
        indexCol++;
    }
    indexCol = 0;
    indexRow++;
    Console.WriteLine();
}
Console.WriteLine();

indexCol = 0;
indexRow = 0;

double [,] array2 = new double [m, n];

for (int i = 0; i < m; i++) // задаем массив целых чисел от -9 до 9
{
    for (int j = 0; j < n; j++)
    {
        array2 [indexRow, indexCol] = new Random().Next(-9, 10);
        indexCol++;
    }
    indexCol = 0;
    indexRow++;
    Console.WriteLine();
}

indexCol = 0;
indexRow = 0;

double [,] array3 = new double [m, n];

for (int i = 0; i < m; i++) // складываем 2 массива и получаем и выводим массив вещественных чисел от -9 до 9
{
    for (int j = 0; j < n; j++)
    {
        array3 [indexRow, indexCol] = array1 [indexRow, indexCol] + array2 [indexRow, indexCol];
        array3 [indexRow, indexCol] = Math.Round(array3 [indexRow, indexCol], 3);
        Console.Write($"{array3 [indexRow, indexCol]}  ");
        indexCol++;
    }
    indexCol = 0;
    indexRow++;
    Console.WriteLine();
    Console.WriteLine();
}