// 22. Найти расстояние между точками в пространстве 2D

Console.WriteLine("Введите координаты первой точки (x, y): ");
double num_1x = Convert.ToDouble(Console.ReadLine());
double num_1y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x, y): ");
double num_2x = Convert.ToDouble(Console.ReadLine());
double num_2y = Convert.ToDouble(Console.ReadLine());

double form = ((num_2x - num_1x)*(num_2x - num_1x) + (num_2y - num_1y)*(num_2y - num_1y));
double distance = Math.Sqrt(form);

Console.WriteLine($"Расстояние между точками равно {distance}");
