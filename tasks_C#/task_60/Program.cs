// 60. Составить частотный словарь элементов двумерного массива

Console.Clear();
Console.WriteLine("Введите сколько нужно строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сколько нужно столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

int indexCol = 0;
int indexRow = 0;

int [,] array = new int [n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[indexRow, indexCol] = new Random().Next(0,10);
        Console.Write($"{}")
    }
}
