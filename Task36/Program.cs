/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateNewArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);

    }
    return array;
}

int findSumOfOddIndexNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

void showArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] array = CreateNewArray(5, -10, 10);
int res = findSumOfOddIndexNumbers(array);
showArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {res}");
