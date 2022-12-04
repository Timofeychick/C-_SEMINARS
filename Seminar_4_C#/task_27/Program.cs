// 28. Подсчитать сумму цифр в числе

// а вдруг число будет отрицательное? - такое может быть и в общем-то сумму цифр в таком числе тоже можно поститать, но без учета минума

// реализовано:
Console.WriteLine("Напишите ваше целое число: ");
int usNumber = Convert.ToInt32(Console.ReadLine());
string sNumbers = usNumber.ToString();
char [] array = sNumbers.ToCharArray();

int index = 0;
int len = array.Length;
int result = 0;

if (usNumber > 0) 
{
    while (index < len)
    {
        string num = array[index].ToString();
        int finNum = Convert.ToInt32(num);
        result = result + finNum;
        index++;
    }
}
else 
{
    index = 1;
    while (index < len)
    {
        string num = array[index].ToString();
        int finNum = Convert.ToInt32(num);
        result = result + finNum;
        index++;
    }
}
Console.WriteLine($"Сумма цифр в вашем числе равна: {result}");