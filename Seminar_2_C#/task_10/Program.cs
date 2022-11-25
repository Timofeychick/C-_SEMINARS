//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите 3-х значное число");

int number = Convert.ToInt32(Console.ReadLine());

string str_number = Convert.ToString(number);

Console.WriteLine(str_number[1]);




