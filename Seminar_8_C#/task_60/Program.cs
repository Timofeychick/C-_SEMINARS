//63. Сформировать трехмерный массив не повторяющимися двузначными числами и показать 
//    его построчно на экран выводя индексы соответствующего элемента
int cube = 3; // размер куба
int [,,] array = new int [cube,cube,cube];

double size = Math.Pow(cube, 3);
int sizeNumbers = Convert.ToInt32(size);
int [] arrayNumbers = new int[sizeNumbers];

for (int i = 0; i < sizeNumbers; i++)
{
    arrayNumbers[i] = new Random().Next(10,101);
    Console.Write($"{arrayNumbers[i]} ");
}

int variable1 = 0;
int variable2 = 0;
int counter = 0;
int index1 = 0;
while(counter < 1000)
{
    while(index1 < sizeNumbers - 1)
    {
        variable2 = arrayNumbers[index1];
        variable1 = arrayNumbers[index1 + 1];
        if (arrayNumbers[index1] > arrayNumbers[index1 + 1])
        {
            arrayNumbers[index1] = variable1;
            arrayNumbers[index1 + 1] = variable2;
        }
        index1++;   
    }
    index1 = 0;
    counter++;
}

Console.WriteLine(); 
Console.WriteLine(); 

int index2 = 0;
for (int i = 0; i < cube; i++) // задаем и выводим куб
{
    for (int j = 0; j < cube; j++)
    {
        for (int k = 0; k < cube; k++)
        {
            array[i, j, k] = arrayNumbers[index2];
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            index2++;  
        }
        Console.WriteLine(); 
    }
    Console.WriteLine();
}

