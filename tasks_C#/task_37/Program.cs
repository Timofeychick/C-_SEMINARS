// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int [] array_1 = new int [123];
for (int i = 0; i < array_1.Length; i++) {
    array_1[i] = new Random().Next(1,123);
    Console.Write($"{array_1[i]} ");
}
Console.WriteLine();
Console.WriteLine();
int [] array_2  = new int [80];
int index = 9;
for (int j = 0; j < array_2.Length; j++) {
    array_2[j] = array_1[index];
    index++;
    Console.Write($"{array_2[j]} ");
}
Console.WriteLine();
Console.WriteLine();

int result = 0;
for (int k = 0; k < array_2.Length; k++){
    int num = array_2[k];
    if (num < 10) {
        result = result + 1;
    }
    else if (9 < num && num < 100) {
        result = result + 2;
    }
    else {
        result = result + 3;
    }
}
Console.WriteLine();
Console.Write($"В этом отрезке массива {result} элементов");