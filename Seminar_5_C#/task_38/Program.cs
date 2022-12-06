// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int [] array = new int [20];
int result = 0;
for (int i = 0; i < array.Length; i++) 
{
    array[i] = new Random().Next(0, 100);
    Console.Write ($"{array[i]} ");
}
Console.WriteLine();
for (int j = 1; j < array.Length; j = j + 2) 
{
    result += array[j];
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел стоящих на нечетной позиции равна {result} ");
Console.WriteLine("(Нечетная позиция самого индекса, а не позиция числа в массиве)");