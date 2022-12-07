// 56. Написать программу, которая обменивает элементы первой строки и последней строки
// Сделал в тупую :)))))
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
        Console.Write($"{array[indexRow, indexCol]} ");
        if (indexCol == indexRow) result += array[indexRow, indexCol];
        indexCol++;
    }
    Console.WriteLine();
    indexRow++;
    indexCol = 0;
}
Console.WriteLine();

int [] arrayMemoryOne = new int [n];
int [] arrayMemoryTwo = new int [n];

indexRow = 9;
for (int i = 0; i < n; i++) // 1
{
    arrayMemoryTwo[i] = array[indexRow, indexCol];
    indexCol++;
}

indexRow = 0;
indexCol = 0;
for (int i = 0; i < n; i++) // 2
{
    arrayMemoryOne[i] = array[indexRow, indexCol];
    indexCol++;
}

indexRow = 0;
indexCol = 0;
for (int i = 0; i < n; i++) // 3 
{
    array[indexRow, indexCol] = arrayMemoryTwo[i];
    indexCol++;
}

indexRow = 9;
indexCol = 0;
for (int i = 0; i < n; i++) // 4
{
    array[indexRow, indexCol] = arrayMemoryOne[i];
    indexCol++;
}

indexRow = 0;
indexCol = 0;
for (int j = 0; j < m; j++)
{
    for (int i = 0; i < n; i++)
    {   
        Console.Write($"{array[indexRow, indexCol]} ");
        indexCol++;
    }
    Console.WriteLine();
    indexRow++;
    indexCol = 0;
}
Console.WriteLine();