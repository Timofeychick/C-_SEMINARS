// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
//                 столбцы / строки
int m = 10; // сколько строк (индекс сверху вних от 0 до m)
int n = 10; // cколько cтолбцов (индекс справа налево от 0 до n)

int [,] array = new int [m, n];

int indexRow = 0; // столбцы (по вертикали)
int indexCol = 0; // строки (по горизонтали)
int counter1 = 0;
int counter2 = 0;

while (indexRow < m)
{
    for (int i = 0; i < n; i++)
    {
        array[indexRow, indexCol] = counter1;
        Console.Write($"{array[indexRow, indexCol]},      ");
        counter1 += 1;
    }
    Console.WriteLine();
    Console.WriteLine();
    counter2++;
    counter1 = counter2;
    indexRow++;
}

