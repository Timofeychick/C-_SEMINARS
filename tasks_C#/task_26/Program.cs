// 26. Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Напишите какое число нужно возвети в стпень:");
int us_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите в какую стпень нужно возвести число");
int rate = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i < rate + 1; i++){
    result = result*us_number;
}
Console.WriteLine(result);