// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 101);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
        sum = sum + array[i];
    return sum;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateArray(length);
PrintArray(Array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна " + Sum(Array));