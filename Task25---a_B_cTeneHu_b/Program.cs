// Задача 25: Напишите цикл, который 
//     принимает на вход два числа (A и B) 
//     и возводит число A в натуральную степень B.
//         3, 5 -> 243 (3⁵)
//         2, 4 -> 16

int GetNumber(string txt)
{
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

double CyclePow(int digit, int size)
{
    double result = digit;
    for (int i = 1; i < Math.Abs(size); i++)
        result *= digit;
    if (size > 0)
        return result;
    else if (size < 0)
        result = (1 / result);
    else result = 1;
    return result;
}

int A = GetNumber("Принимаю на вход число A: ");
int B = GetNumber("Принимаю на вход число B (степень числа A): ");
System.Console.WriteLine($"{A} возведённое в степень {B} соответствует {CyclePow(A, B)}");

System.Console.WriteLine($"{A} возведённое в степень {B} соответствует {Math.Pow(A, B)}");