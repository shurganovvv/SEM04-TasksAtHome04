// Задача 29: Напишите программу, которая 
//     задаёт массив из 8 элементов 
//     и выводит их на экран.
//         1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
//         6, 1, 33 -> [6, 1, 33]

int GetNumber(string txt)
{
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int sise, int min, int max)
{
    int[] array = new int[sise];
    for (int i = 0; i < sise; i++)
        array[i] = new Random().Next(min, max+1);
    return array;
}

int numbers = GetNumber("задайте кол-во элементов массива: ");
int a = GetNumber("задайте минимальное число в массиве: ");
int z = GetNumber("задайте максимальное число в массиве: ");
int[] mas = GetArray(numbers, a, z);
System.Console.WriteLine($"[{string.Join(", ", mas)}]");