// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива, 
// возможно придется кое-что для этого дополнительно выполнить.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 11);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int MinNumber(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int MaxNumber(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int MinIndex(int[] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}

int MaxIndex(int[] array)
{
    int max = array[0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            index = i;
        }
    }
    return index;
}

int Average(int[] array)
{
    int sum = 0;
    int average = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    average = sum / array.Length;
    return average;
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int Median(int[] array)
{
    int median = 0;
    if (array.Length % 2 == 0)
        median = (((array[array.Length / 2 - 1]) + (array[array.Length / 2])) / 2);
    else median = (array[array.Length / 2]);
    return median;
}

Console.Write("Введите размерность массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] Array = CreateArray(length);
PrintArray(Array);

int[] myArray = new int[5];
myArray[0] = MinNumber(Array);
myArray[1] = MaxNumber(Array);
myArray[2] = MinIndex(Array);
myArray[3] = MaxIndex(Array);
myArray[4] = Average(Array);
Console.Write("Измененный массив: ");
PrintArray(myArray);

Console.Write("Минимальный элемент массива: " + MinNumber(Array));
Console.WriteLine();
Console.Write("Максимальный элемент массива: " + MaxNumber(Array));
Console.WriteLine();
Console.Write("Индекс минимального элемента массива: " + MinIndex(Array));
Console.WriteLine();
Console.Write("Индекс максимального элемента массива: " + MaxIndex(Array));
Console.WriteLine();
Console.Write("Среднее арифметическое всех элементов массива равно: " + Average(Array));
Console.WriteLine();
SelectionSort(Array);
Console.Write("Массив отсортирован по возрастанию: ");
PrintArray(Array);
Console.Write("Медианное значение первоначалального массива равно: " + Median(Array));
Console.WriteLine();