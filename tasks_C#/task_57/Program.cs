// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// не стал пользоваться функцией Sort (так не интересно, ыы)
Console.Clear();
int m = 20;
int n = 20;
int [,] array = new int [m, n];
int indexCol = 0;
int indexRow = 0;

Console.WriteLine("Исходный массив:");
Console.WriteLine();

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
}
Console.WriteLine();
indexCol = 0;
indexRow = 0;

Console.WriteLine("Массив, отсортированный по строкам:");
Console.WriteLine();

int counter = 0; // счетчик сравнения чисел между собой, чем больше раз сравнит - тем точнее сортировка! 
int timer = n * m * 10; // сколько раз будет выполняться сравнение - взял с запасом, но меньшего кол-ва тоже должно хватить
int variable1 = 0; // сохраняет значение элемента с условным индексом 1 перед элементом с индексом 2
int variable2 = 0; // сохраняет значение элемента с условным индексом 2 после элемента с индексом 1
for (int i = 0; i < m; i++) // сортируем строки в массиве
{
    for (int j = 0; j < n; j++)
    {
        while (counter < timer)
        {
            while (indexCol < n - 1)
            {
                variable1 = array[indexRow, indexCol + 1];
                variable2 = array[indexRow, indexCol];
                if (array[indexRow, indexCol] < array[indexRow, indexCol + 1]) //чтобы сделать от меньшего к большему - поменять '<' на '>'
                {
                    array[indexRow, indexCol] = variable1;
                    array[indexRow, indexCol + 1] = variable2;
                }
                indexCol++;
            }
            indexCol = 0;
            counter++;
        }
        Console.Write($"{array[indexRow, indexCol]} ");
        indexCol++;
    }
    counter = 0;
    indexCol = 0;
    indexRow++;
    Console.WriteLine();
}
Console.WriteLine();
// хштэг да это жоска