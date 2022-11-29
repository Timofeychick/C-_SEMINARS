// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Координату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четверь");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Вторая четверть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Четвертая четверть");
}