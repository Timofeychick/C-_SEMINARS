// 28. Подсчитать сумму цифр в числе

// а вдруг число будет отрицательное? - такое может быть и в общем-то сумму цифр в таком числе тоже можно поститать, но без учета минума

// реализовано:
Console.WriteLine("Напишите ваше целое число: ");
int us_number = Convert.ToInt32(Console.ReadLine());
string s_numbers = us_number.ToString();
char [] array = s_numbers.ToCharArray();

int index = 0;
int len = array.Length;
int result = 0;

if (us_number > 0) 
{
    while (index < len)
    {
        string num = array[index].ToString();
        int fin_num = Convert.ToInt32(num);
        result = result + fin_num;
        index++;
    }
}
else 
{
    index = 1;
    while (index < len)
    {
        string num = array[index].ToString();
        int fin_num = Convert.ToInt32(num);
        result = result + fin_num;
        index++;
    }
}
Console.WriteLine($"Сумма цифр в вашем числе равна: {result}");