// 61. Найти произведение двух матриц
// Для того чтобы перемножить матрицы, они долдны быть совметсимы: количетсво столбцов в умножаемой матрице должно равняться количеству
// столбцов в матрице - множителе
Console.Clear();
Console.WriteLine("Введите количество столбцов умножаемой матрицы:");
int column  = Convert.ToInt32(Console.ReadLine()); // столбцы умножаемой матрицы
Console.WriteLine("Введите количество строк умножаемой матрицы:");
int row = Convert.ToInt32(Console.ReadLine()); // строки умножаемой матрицы
Console.WriteLine("Введите количество столбцов матрицы - множителя");
int columnMult = Convert.ToInt32(Console.ReadLine()); // столбцы матрицы - множителя
int rowMult = column;

int [,] array1 = new int [row, column]; // умножаемая матрица 
int [,] array2 = new int [rowMult, columnMult]; // матрица - множитель
int [,] array3 = new int [row, columnMult]; // матрица - результат

Console.WriteLine("Умножаемая матрица:");
Console.WriteLine();

for (int i = 0; i < row; i++) // задание умножаемой матрицы
{
    for (int j = 0; j < column; j++)
    {
        array1[i,j] = new Random().Next(4,10); // Next задает диапазон случайных значений в интервале [4, 10) (можно поменять)
        Console.Write($"{array1[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Матрица - множитель:");
Console.WriteLine();

for (int i = 0; i < rowMult; i++) // задание матрицы - множителя
{
    for (int j = 0; j < columnMult; j++)
    {
        array2[i,j] = new Random().Next(4,10); // Next задает диапазон случайных значений в интервале [4, 10) (можно поменять)
        Console.Write($"{array2[i,j]} ");
    }
    Console.WriteLine();
}

int result = 0; // значение элемента в итоговой матрице после суммирования всех "multiple"
int multiple = 0; // результат перемножения элементов в умножаемой матрице и матрице - множителе (последовательно, по правилу перемножения матриц)

for (int k = 0; k < columnMult; k++) // находим произведение двух матриц
{
    for (int j = 0; j < row; j++)
    {
        for (int i = 0; i < column; i++)
        {
            multiple = array1[j, i] * array2[i, k];
            result += multiple;
        }
        array3[j,k] = result;
        result = 0;
    }
}
Console.WriteLine();
Console.WriteLine("Результат перемножения:");
Console.WriteLine();

for (int i = 0; i < row; i++) // выводим произведение двух матриц
{
    for (int j = 0; j < columnMult; j++)
    {
        Console.Write($"{array3[i, j]} ");
    }
    Console.WriteLine();
}