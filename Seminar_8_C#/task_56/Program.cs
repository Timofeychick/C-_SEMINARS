// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
// какая вообще разница (для задачи) прямоугольная или квадратная?
// квадрат - это частный случай прямоугольника, кек лол ы

Console.Clear();

Console.Write("введите количество cтрок:  ");
int row = Convert.ToInt32(Console.ReadLine()); // m
Console.Write("введите количество столбцов:  ");
int column = Convert.ToInt32(Console.ReadLine()); // n
Console.WriteLine();

int [,] array = new int [row, column];

for (int j = 0; j < row; j++) // задаем массив 
{
    for (int i = 0; i < column; i++)
    {   
        array[j, i] = new Random().Next(10,100);
        Console.Write($"{array[j, i]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int sum = 0;
int result = 1000000;
int str = 0;
for (int i = 0; i < row; i++ )
{
    for (int j = 0; j < column; j++)
    {
        sum += array[i, j];
    }
    if (sum < result) result = sum;
    if (result == sum) str = i;
    sum = 0;
}

Console.WriteLine($"Наименьшая сумма элементов равна: {result}, индекс строки: ({str})");