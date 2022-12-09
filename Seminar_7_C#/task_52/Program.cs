// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();
int m = 10;
int n = 10;
int [,] array = new int [m, n];
int indexCol = 0;
int indexRow = 0;

for (int j = 0; j < m; j++)
{
    for (int i = 0; i < n; i++)
    {   
        array[indexRow, indexCol] = new Random().Next(10,100);
        Console.Write($"{array[indexRow, indexCol]}  ");
        indexCol++;
    }
    Console.WriteLine();
    indexRow++;
    indexCol = 0;
}
indexRow = 0;
Console.WriteLine();

double result = 0;
int count = 1;
for (int i = 0; i < n; i++) 
{
    for (int j = 0; j < m; j++)
    {   
        result += array[indexRow, indexCol];
        indexRow++;
    }
    result = result / m;
    Console.WriteLine($"Среднее арифметическое {count} столбца равно {result}");
    count++;
    result = 0;
    indexRow = 0;
    indexCol++;
}