// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int [] array = new int [8]; 

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(0,2); // при такой записи 0 включатеся, а 2 нет
    Console.Write($"{array[i]} ");
}
