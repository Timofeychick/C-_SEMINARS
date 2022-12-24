// 71. Написать программу вычисления функции Аккермана
// функция Аккермана может быть опеределена рекурсивно для неотрицательных целых чиселm и n следующим образом:
//            | n + 1,        m = 0;
// A (m, n) = | A(m - 1, 1),  m > 0, n = 0;
//            | A(m - 1, A(m. n - 1)), m > 0; n > 0;
// INPUT. В каждой строке входных данных находятся два неотрицательных целых числа m и n, где 0 ≤ m ≤ 3. 
// Для всех m < 3 значение n не превышает 1000000, если же m = 3, то значение n не превышает 24.
// OUTPUT. Для каждой заданной пары чисел выведите в отдельной строке искомое значение функции Аккермана A(m, n).


int AckermanFunction(int nuberM, int nunberN)
{
    if(nuberM == 0)
        return nunberN + 1;
    if( nuberM > 0 && nunberN == 0)
        return AckermanFunction(nuberM - 1, 1);
    else
        return AckermanFunction(nuberM - 1, AckermanFunction(nuberM, nunberN - 1));
}

int AddNumber(string messege)
{
    Console.WriteLine(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int userNumberM = AddNumber("Введите число M");
int userNumberN = AddNumber("Введите число N");
int Ackerman = AckermanFunction(userNumberM, userNumberN);
Console.WriteLine(Ackerman);