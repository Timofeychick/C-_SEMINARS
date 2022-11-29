// 22. Найти расстояние между точками в пространстве 3D

Console.WriteLine("Введите координаты первой точки (x, y, z): ");
double num_1x = Convert.ToDouble(Console.ReadLine());
double num_1y = Convert.ToDouble(Console.ReadLine());
double num_1z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x, y, z): ");
double num_2x = Convert.ToDouble(Console.ReadLine());
double num_2y = Convert.ToDouble(Console.ReadLine());
double num_2z = Convert.ToDouble(Console.ReadLine());


double form = ((num_2x - num_1x)*(num_2x - num_1x) + (num_2y - num_1y)*(num_2y - num_1y) + (num_2z - num_1z)*(num_2z - num_1z));
double distance = Math.Sqrt(form);

Console.WriteLine($"Расстояние между точками равно {distance}");
