// 24. Найти кубы чисел от 1 до N

Console.WriteLine("Напишите до какого числа показать таблицу кубов");

int us_number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < us_number + 1; i++) {
    int cube = i*i*i;
    Console.WriteLine($"{i}^3 = {cube}");
}