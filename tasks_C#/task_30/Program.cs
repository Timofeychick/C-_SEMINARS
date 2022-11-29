// 30. Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Напишите ваше число: ");
int us_number = Convert.ToInt32(Console.ReadLine());
int cube = 1;

Console.WriteLine("Кубы чисел: ");

for (int i = 1; i < us_number + 1; i++) {
    
    if (i % 2 == 0) {
        cube = i*i*i;
        Console.WriteLine($"{i}^3 = {cube}");
    }
}

