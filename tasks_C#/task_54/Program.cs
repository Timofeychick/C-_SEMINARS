// 54. В матрице чисел найти сумму элементов главной диагонали

Console.Clear();
int m = 10;
int n = 10;
int [,] array = new int [m, n];
int indexCol = 0;
int indexRow = 0;
int result = 0;
for (int j = 0; j < m; j++)
{
    for (int i = 0; i < n; i++)
    {   
        array[indexRow, indexCol] = new Random().Next(10,100);
        Console.Write($"{array[indexRow, indexCol]}   ");
        if (indexCol == indexRow) result += array[indexRow, indexCol];
        indexCol++;
    }
    Console.WriteLine();
    Console.WriteLine();
    indexRow++;
    indexCol = 0;
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел стоящих на главной диагонали равна {result}");