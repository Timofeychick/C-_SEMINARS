//41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите ваши числа:");
Console.WriteLine("После ввода числа нажмите Enter:");
Console.WriteLine("Чтобы прекратить ввод, введите (end) и нажмите Enter");

int stop = 0;
int count = 0;
while (stop == 0)
{
    string input = Console.ReadLine();
    if (input == "end")
    {
        stop = 1;
    }
    else
    {
        try
        {
            int number = Int32.Parse(input);
            if (number > 0) count += 1;
        }
        catch (FormatException)
        {
            Console.WriteLine($" - это не число");
        }
    }
}
Console.WriteLine($"Вы ввели {count} чисел больше 0");