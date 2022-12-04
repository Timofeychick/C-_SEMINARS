// 31. Задать массив из 8 элементов и вывести их на экран 

int [] array = new int [8];

int len = array.Length;

for (int i = 0; i < len; i++) 
{
    array[i] = new Random().Next(0,100);
    Console.Write($"{array[i]} ");
}


