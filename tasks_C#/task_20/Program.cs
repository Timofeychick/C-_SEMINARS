// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти");

int a = Convert.ToInt32(Console.ReadLine());

if (a == 1) Console.WriteLine("диапазон х от 0 до ++, диапазон y от 0 до ++");
if (a == 2) Console.WriteLine("диапазон х от 0 до ++, диапазон y от -- до 0");
if (a == 3) Console.WriteLine("диапазон x от -- до 0, диапазон y от -- до 0");
if (a == 4) Console.WriteLine("диапазон x от -- до 0, диапазон y от 0 до ++");

