// 34. Написать программу замену элементов массива на противоположные
int [] array = new int [16];
int invers = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(-10, 11);
    invers = array[i] * -1;
    Console.WriteLine($"{array[i]}     {invers}");
}