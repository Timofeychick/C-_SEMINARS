// 62. замутить двумерный спиральный массив
int row = 20;
int column = 20;
int [,] array = new int [row, column];

int number  = 1;

Console.WriteLine();

for (int i = 0; i < column; i++)
{
    array[0, i] = number;
    number++;
}
for (int i = 1; i < row; i++)
{
    array[i, column - 1] = number;
    number++;
}
for (int i = row - 2; i >= 0; i--)
{
    array[row - 1, i] = number;
    number++;
}
for (int i = column - 2; i > 0; i--)
{
    array[i, 0] = number;
    number++;
}

int indexCol = 1;
int indexRow = 1;

while (number < row * column)
{
    while (array[indexRow, indexCol + 1] == 0)
    {
        array[indexRow, indexCol] = number;
        number++;
        indexCol++;
    } 
    while (array[indexRow + 1, indexCol] == 0)
    {
        array[indexRow, indexCol] = number;
        number++;
        indexRow++;
    }
    while (array[indexRow, indexCol - 1] == 0)
    {
        array[indexRow, indexCol] = number;
        number++;
        indexCol--;
    }
    while (array[indexRow - 1, indexCol] == 0)
    {
        array[indexRow, indexCol] = number;
        number++;
        indexRow--;
    }
}

for (int i = 0; i < row; i++) 
{
    for (int j = 0; j < column; j++) 
    {
        if (array[i, j] == 0) 
        {
            array[i, j] = number;
        }
    }
}

for (int i = 0; i < row; i++) 
{
    for (int j = 0; j < column; j++) 
    {
        if (row * column > 100 )
        {
            if (array[i, j] < 10)
            {
                Console.Write($"{0}{0}{array[i, j]} ");
            }
            else if (array[i, j] < 100)
            {
                Console.Write($"{0}{array[i, j]} ");
            }
            else 
            {
                Console.Write($"{array[i, j]} ");
            }            
        }
        else 
        {
            if (array[i, j] < 10)
            {
                Console.Write($"{0}{array[i, j]} ");
            }
            else 
            {
                Console.Write($"{array[i, j]} ");
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}
