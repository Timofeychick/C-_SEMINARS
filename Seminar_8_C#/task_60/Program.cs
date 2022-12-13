//63. Сформировать трехмерный массив не повторяющимися двузначными числами и показать 
//    его построчно на экран выводя индексы соответствующего элемента
int cube = 3; // размер куба
int [,,] array = new int [cube,cube,cube];

for (int i = 0; i < cube; i++) // задаем куб
{
    for (int j = 0; j < cube; j++)
    {
        for (int k = 0; k < cube; k++)
        {
            array[i, j, k] = new Random().Next(10,100);
        }   
    }
}

int number = 10;

while (number < 100) // этот цикл уберает возможные совпадения (что-то ничего лучше не придумал)
{
    for (int i = 0; i < cube; i++)
    {
        for (int j = 0; j < cube; j++)
        {
            for (int k = 0; k < cube; k++)
            {
                if (array[i, j, k] == number) array[i, j, k] -= 1;
                
            }
            number++; 
        }
    }
    number -= 5;
}

for (int i = 0; i < cube; i++) // выводим куб
{
    for (int j = 0; j < cube; j++)
    {
        for (int k = 0; k < cube; k++)
        {
            Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}