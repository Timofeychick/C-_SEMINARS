// 48. Показать двумерный массив размером m×n заполненный целыми числами

Console.WriteLine("Напишите размер массива по вертикали");
int m = Convert.ToInt32(Console.ReadLine()); // row
Console.WriteLine("Напишите размер массива по горизонтали");
int n = Convert.ToInt32(Console.ReadLine()); // column
Console.WriteLine();
int [,] array = new int [n, m];

int id1 = 0;
int id2 = 0;

while (id2 < m)
{
    while(id1 < n)
    {
        array[id1, id2] = new Random().Next(0,9);
        Console.Write($"{array[id1,id2]} ");
        id1++;
    }
    id1 = 0;
    id2 = id2 + 1;
    Console.WriteLine();
}