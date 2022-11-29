// 25. Найти сумму чисел от 1 до А

Console.WriteLine("До какого числа нужно показать сумму?");
int us_number = Convert.ToInt32(Console.ReadLine());
int result = 0;
int num = us_number;
for (int i = 0; i < us_number; i++){
    result = result + num;
    num = num - 1;
}
Console.WriteLine(result);