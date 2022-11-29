// 31. Задать массив из 8 элементов и вывести их на экран 

int [] array = {1, 2, 3, 4, 5, 6, 7, 8};

int len = array.Length;
int num = 0;
for (int i = 0; i < len; i++) {
    num = array[i];
    Console.Write($"{num} ");
}


