// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// не стал пользоваться функцией Sort (так не интересно, ыы)
Console.Clear();
int row = 20; // сколько строк
int column = 20; // сколько столбцов
int [,] array = new int [row, column];

Console.WriteLine("Исходный массив:");
Console.WriteLine();

for (int j = 0; j < row; j++) // задаем массив 
{
    for (int i = 0; i < column; i++)
    {   
        array[j, i] = new Random().Next(10,100);
        Console.Write($"{array[j, i]} ");    
    }
    Console.WriteLine();
}
Console.WriteLine();
int indexCol = 0; // индекс столбца
int indexRow = 0; // индекс строки

Console.WriteLine("Массив, отсортированный по строкам:");
Console.WriteLine();

int counter = 0; // счетчик сравнения чисел между собой, чем больше раз сравнит - тем точнее сортировка! 
int timer = row * column * 10; // сколько раз будет выполняться сравнение - взял с запасом, но меньшего кол-ва тоже должно хватить
int variable1 = 0; // сохраняет значение элемента с условным индексом 1 перед элементом с индексом 2
int variable2 = 0; // сохраняет значение элемента с условным индексом 2 после элемента с индексом 1
for (int i = 0; i < row; i++) // сортируем строки в массиве
{
    for (int j = 0; j < column; j++)
    {
        while (counter < timer)
        {
            while (indexCol < column - 1)
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
