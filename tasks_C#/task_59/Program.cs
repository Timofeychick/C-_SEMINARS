// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
// какая вообще разница (для задачи) прямоугольная или квадратная?
// квадрат - это частный случай прямоугольника, кек лол ы

Console.Clear();

Console.Write("введите количество cтрок:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] array = new int [m, n];
int indexCol = 0;
int indexRow = 0;

for (int j = 0; j < m; j++) // задаем массив 
{
    for (int i = 0; i < n; i++)
    {   
        array[indexRow, indexCol] = new Random().Next(10,100);
        Console.Write($"{array[indexRow, indexCol]} ");
        indexCol++;   
    }
    indexCol = 0;
    indexRow++;
    Console.WriteLine();
    Console.WriteLine();
}
indexCol = 0;
indexRow = 0;

int sum = 0;
int result = 1000000;
int str = 0;
for (int i = 0; i < m; i++ )
{
    for (int j = 0; j < n; j++)
    {
        sum += array[indexRow, indexCol];
        indexCol++;
    }
    if (sum < result) result = sum;
    if (result == sum) str = indexRow;
    sum = 0;
    indexCol = 0;
    indexRow++;
}

Console.WriteLine($"Наименьшая сумма элементов равна: {result}, индекс строки: ({str})");