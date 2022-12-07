// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int m = 10;
int n = 10;

int [,] array = new int [m, n];

int indexCol = 0;
int indexRow = 0;

while (indexRow < n)
{
    for (int i = 0; i < m; i++)
    {
        array[indexRow, indexCol] = new Random().Next(1,4);
        if (indexCol % 2 == 0 && indexRow % 2 == 0) array[indexRow, indexCol] = array[indexRow, indexCol] * array[indexRow, indexCol];
        Console.Write($"{array[indexRow, indexCol]}   ");
        indexCol++;
    }
    Console.WriteLine();
    Console.WriteLine();
    indexCol = 0;
    indexRow++;
}