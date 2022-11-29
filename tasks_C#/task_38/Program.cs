// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int [] array = new int [5];
int result = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(0, 100);
    Console.Write ($"{array[i]} ");
}

for (int j = 0; j < array.Length; j = j + 2) {
    result = result + array[j];
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел стоящих на нечетной позиции равна {result} ");