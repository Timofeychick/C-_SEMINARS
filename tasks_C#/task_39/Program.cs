// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int [] array = new int [20];
int [] array_one = new int [20];
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(2,6);
    array_one[i] = array[i];
    Console.Write(array[i]);
}
Console.WriteLine();

Array.Reverse(array);

for (int i = 0; i < array.Length; i++) {
    Console.Write(array[i]);
}
Console.WriteLine();

int res = 0;
for (int i = 0; i < array_one.Length; i++) {
    res = array_one[i] * array[i];
    Console.WriteLine($"{array_one[i]} * {array[i]} = {res} ");
}