// 41. Выяснить являются ли три числа сторонами треугольника 
Console.WriteLine("Введите 3 числа:");
Console.WriteLine("Первое:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Второе:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Третье:");
double c = Convert.ToDouble(Console.ReadLine());
if (a + b > c) {
    if (a + c > b) {
        if (b + c > a) {
            Console.WriteLine("Эти три числа являются сторонами треугольника");
        }
    }
}
else {
    Console.WriteLine("Эти три числа не могут быть сторонами треугольника");
}