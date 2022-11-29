// 33. Задать массив из 12 элементов, заполненных числами. Найти сумму положительных/отрицательных элементов массива
int [] array = new int [12];

int sum_minus = 0;
int sum_plus = 0;

for (int i = 0; i < array.Length; i++ ) {
    array[i] = new Random().Next(-5, 7);
    if (array[i] > 0) {
        sum_plus = sum_plus + array[i];
    }
    else {
        sum_minus = sum_minus - array[i];
    }
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов равна: {sum_plus}");
Console.WriteLine($"Сумма отрицательных элементов равна: {sum_minus} (по модулю)");