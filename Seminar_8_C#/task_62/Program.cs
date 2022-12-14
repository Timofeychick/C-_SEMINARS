// 62. замутить двумерный спиральный массив
int row = 20;
int column = 20;
int [,] array = new int [row, column];

int number  = 1;

Console.WriteLine();
// в этих циклах мы бежим по периметру, начиная с элемента с индексом [0, 0]
for (int i = 0; i < column; i++) // идем вправо
{
    array[0, i] = number;  
    number++;
}
for (int i = 1; i < row; i++) // идем вниз
{
    array[i, column - 1] = number;
    number++;
}
for (int i = row - 2; i >= 0; i--) // идем наверх
{
    array[row - 1, i] = number;
    number++;
}
for (int i = column - 2; i > 0; i--) // идем вверх
{
    array[i, 0] = number;
    number++;
}

int indexCol = 1;
int indexRow = 1;
// периметр заполнен, теперь внутрянка; Так как функция new int [,] заполняет массив нулями, внтурянка заполнена нулями
// таким образом цикл будет бегать вправо/вниз/влево/наверх до тех пор, пока не останется нулей (кроме последнего элемнта)
while (number < row * column) // row * column - размер массива 
{
    while (array[indexRow, indexCol + 1] == 0) // идем вправо
    {
        array[indexRow, indexCol] = number;
        number++;
        indexCol++;
    } 
    while (array[indexRow + 1, indexCol] == 0) // идем вниз
    {
        array[indexRow, indexCol] = number;
        number++;
        indexRow++;
    }
    while (array[indexRow, indexCol - 1] == 0) // идем влево
    {
        array[indexRow, indexCol] = number;
        number++;
        indexCol--;
    }
    while (array[indexRow - 1, indexCol] == 0) // идем вверх
    {
        array[indexRow, indexCol] = number;
        number++;
        indexRow--;
    }
}

for (int i = 0; i < row; i++)  // убирает последний ноль
{
    for (int j = 0; j < column; j++) 
    {
        if (array[i, j] == 0) 
        {
            array[i, j] = number;
        }
    }
}

for (int i = 0; i < row; i++) // добавление 00 перед простым числом и 0 перед двузначным числом и вывод
{
    for (int j = 0; j < column; j++) 
    {
        if (row * column > 100 )
        {
            if (array[i, j] < 10)
            {
                Console.Write($"{0}{0}{array[i, j]} ");
            }
            else if (array[i, j] < 100)
            {
                Console.Write($"{0}{array[i, j]} ");
            }
            else 
            {
                Console.Write($"{array[i, j]} ");
            }            
        }
        else 
        {
            if (array[i, j] < 10)
            {
                Console.Write($"{0}{array[i, j]} ");
            }
            else 
            {
                Console.Write($"{array[i, j]} ");
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}
