// 43. Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Напишите ваше число для его конвертации в двоичную форму: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber < 0) 
{
    Console.WriteLine("Недопустимое значние");
}
else if (userNumber == 0) 
{ 
    Console.WriteLine("Ноль он и есть ноль");
}
else 
{
    int convertNumber = userNumber;

    int count = 0;

    while (userNumber > 0.99)
    {
        count = count + 1;
        userNumber = userNumber / 2;
    }

    int [] array = new int [count];

    int variable = 0;

    for(int index = 0; convertNumber > 0.99; index++)
    {
        if (convertNumber % 2 > 0) 
        {   
            variable = 1;
           array[index] = variable;
        }
        else
        {
        variable = 0;
        array[index] = variable;
        }
       convertNumber = convertNumber / 2;
    }

    Array.Reverse(array);

    Console.WriteLine("В двоичной форме ваше числовыглядит так: ");

    for (int index = 0; index < count; index++)
    {
        Console.Write($"{array[index]}");   
    }
}