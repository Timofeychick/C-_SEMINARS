// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int [] array = new int [20];
int res_even = 0;
int res_odd = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) {
        res_even = res_even + 1;
    }
    else {
        res_odd = res_odd + 1;
    }

}
for (int i = 0; i < array.Length; i++) {
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine($" Колличество четных чисел = {res_even}");
Console.WriteLine($" Колличество нечетных чисел = {res_odd}");