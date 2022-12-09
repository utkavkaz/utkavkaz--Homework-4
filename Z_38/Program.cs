// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число массива под индексом {i}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] Array = FillArray(length);
PrintArray(Array);
Console.Write("Минимальный элемент массива: " + Min(Array));
Console.WriteLine();
Console.Write("Максимальный элемент массива: " + Max(Array));
Console.WriteLine();
double result = Max(Array) - Min(Array);
Console.Write("Разница между максимальным и минимальным элементами массива равна: " + (result));