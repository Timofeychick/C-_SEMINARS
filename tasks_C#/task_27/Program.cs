// 27. Определить количество цифр в числе
Console.WriteLine("Напишите ваше число:");
int us_number = Convert.ToInt32(Console.ReadLine());
string num_1 = us_number.ToString();
char [] array = num_1.ToCharArray();
int n = array.Length;
Console.WriteLine($"В вашем числе {n} цифр");

