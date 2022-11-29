// 23 Показать таблицу квадратов чисел от 1 до N 

Console.WriteLine("Напишите до какого числа показать таблицу");

int us_number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < us_number + 1; i++) {
    int sqrt = i*i;
    Console.WriteLine($"{i}^2 = {sqrt}");
}
