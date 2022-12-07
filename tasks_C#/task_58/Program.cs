// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная)


// а нафига ограничиваться квадратными матрицами??? 
// мы и в прямоугольных умеем циферки переставлять :))
// Console.WriteLine(); везде понатыкано для красивого вывода (можно убрать)
Console.Clear();

Console.Write("введите количество столбцов:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество строк:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] array = new int [m, n];
int indexCol = 0;
int indexRow = 0;

Console.WriteLine("Ваш массив случайных цифр: ");
Console.WriteLine();

for (int j = 0; j < m; j++) // задаем массив 
{
    for (int i = 0; i < n; i++)
    {   
        array[indexRow, indexCol] = new Random().Next(10,100);
        Console.Write($"{array[indexRow, indexCol]}   ");
        indexCol++;   
    }
    indexCol = 0;
    indexRow++;
    Console.WriteLine();
    Console.WriteLine();
}
indexCol = 0;
indexRow = 0;
// if (n > m && m > n) Console.WriteLine("Матрица не квадратная - невозможно конвертировать :)"); - ненужное действие, но можно сделать

int [] oneArray = new int [n]; // это вспомогательный массив (используем в качестве одной строки)
int [,] sortArray = new int [n, m]; // это будет уже сконвертированный массив
int indexColSort = 0;
int indexRowSort = 0;

for (int j = 0; j < m; j++) // задаем конвертированный массив 
{
    for (int i = 0; i < n; i++)
    {   
        oneArray[i] = array[indexRow, indexCol];
        indexCol++;   
    }

    for (int k = 0; k < n; k++)
    {
        sortArray[indexRowSort, indexColSort] = oneArray[k];
        indexRowSort++;
    }
    indexColSort++;
    indexRowSort = 0;
    indexCol = 0;
    indexRow++;
}
Console.WriteLine();

indexColSort = 0;
indexRowSort = 0;

Console.WriteLine("Ваш сконвертированный массив случайных цифр: ");
Console.WriteLine();

for (int i = 0; i < n; i++) // выводим конвертированный массив
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{sortArray[indexRowSort, indexColSort]}   ");
        indexColSort++;
    }
    indexColSort = 0;
    indexRowSort++;
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();