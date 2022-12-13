//63. Сформировать трехмерный массив не повторяющимися двузначными числами и показать 
//    его построчно на экран выводя индексы соответствующего элемента
int cube = 2; // размер куба
int [,,] array = new int [cube,cube,cube];

for (int i = 0; i < cube; i++)
{
    for (int j = 0; j < cube; j++)
    {
        for (int k = 0; k < cube; k++)
        {
            array[i, j, k] = new Random().Next(10,100);
            Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");  
            
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}