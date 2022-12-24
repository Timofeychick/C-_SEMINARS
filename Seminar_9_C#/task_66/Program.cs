// Найти сумму элементов от M до N, N и M заданы

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersInBetween(int numberA, int numberB)
{
    if(numberA == numberB)
        return numberB;
    return SumNumbersInBetween(numberA + 1, numberB) + numberA;
}

int AddNumber(string messege)
{
    System.Console.WriteLine(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int userNumberM = AddNumber("Введите первое число");
int userNumberN = AddNumber("Введите второе число");
if(userNumberM < userNumberN)
{
    int sum = SumNumbersInBetween(userNumberM, userNumberN);
    Console.WriteLine(sum);
}
else
    Console.WriteLine("Некоректный ввод");