// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите 3-х значное число");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    string str_num = Convert.ToString(number);
    Console.WriteLine(str_num[1]);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}
