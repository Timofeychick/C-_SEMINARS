// 29. Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Напишите ваше число: ");
int us_number = Convert.ToInt32(Console.ReadLine());

int number = 0; // текущее число
int result = 1; // итоговый результат
for (int i = 1; i < us_number + 1; i++) {
    number = number + 1;
    result = result * number;
}
Console.WriteLine($"Произведение чисел от 0 до N равно {result}");