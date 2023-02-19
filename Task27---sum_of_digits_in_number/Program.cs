// Задача 27: Напишите программу, которая 
//     принимает на вход число 
//     и выдаёт сумму цифр в числе.
//         452 -> 11
//         82 -> 10
//         9012 -> 12

int GetNumber(string txt)
{
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int Numbers(int A)
{
    A = Math.Abs(A);
    int sum = 0;
    while (A / 10 > 0)
    {
        int digit = A % 10;
        A = A / 10;
        sum = sum + digit;
    } sum = sum + A;
    return sum;
}

int numbers = GetNumber("Принимаю на вход число: ");
Console.WriteLine($"Сумма цифр числа {numbers} = {Numbers(numbers)}");