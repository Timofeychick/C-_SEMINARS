// 35. Определить, присутствует ли в заданном массиве, некоторое число 
Console.WriteLine("Введите число, и программа скажет есть ли оно случайном массиве");
int us_number = Convert.ToInt32(Console.ReadLine());
int [] array = new int [30];
int res = 0;
for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(-20, 21);
    if (array[i] == us_number) res = 1;
}
if (res == 1) {
    Console.WriteLine("В этом массиве есть ваше число"); 
}
else {
    Console.WriteLine("В этом массиве нет вашего числа"); 
}

for (int i = 0; i < array.Length; i++) {
    Console.Write($"{array[i]} ");
}