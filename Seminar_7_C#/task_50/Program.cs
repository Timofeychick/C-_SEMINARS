// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.Clear();
Console.WriteLine("Введите ваше целое число");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int m = 10;
int n = 10;

int [,] array = new int [m,n];
int indexCol = 0;
int indexRow = 0;


for (int j = 0; j < m; j++) // 2 цикла задают массив размером [m, n] с диапазоном значений от [10 до 99] (для красивого вывода) 
{
    for (int i = 0; i < n; i++)
    {
        array[indexRow, indexCol] = new Random().Next(10,100);
        Console.Write($"{array[indexRow, indexCol]}   ");
        indexCol++;
    }
    Console.WriteLine();
    Console.WriteLine();
    indexRow++;
    indexCol = 0;
}
indexRow = 0;
Console.WriteLine();

int positionCol = -1;
int positionRow = -1;
int count = 1;
for (int j = 0; j < m; j++) // 2 цикла пробегаются по созданному массиву и ищут каждое совпадение числа пользователя и числом в массвие
{
    for (int i = 0; i < n; i++)
    {
        if (userNumber == array[indexRow, indexCol])
        {
            positionCol = indexCol;
            positionRow = indexRow;
            Console.WriteLine($"Позиция {count} числа в массиве: ({positionRow}, {positionCol}) ");
            count++;
        }
        indexCol++;
    }
    indexCol = 0;
    indexRow++;
}

if (positionRow == -1) Console.WriteLine("В данном массиве нет вашего числа");

//конечно, поиск совпадений можно было запинуть в первые 2 цикла, но, на мой взгляд, было бы слишком громоздко,
//+ так легче дорабатывать и исправлять ошибки в коде :)
