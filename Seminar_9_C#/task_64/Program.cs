// 67. Показать натуральные числа от N до 1, N задано

Console.Clear();
Console.WriteLine("Введите число, от которого показать список натуральных чисел:");

int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

void NaturalNumbers(int number)
{
    Console.Write($"{number} ");
    if (number > 1) NaturalNumbers(number - 1);
}

NaturalNumbers(userNumber);