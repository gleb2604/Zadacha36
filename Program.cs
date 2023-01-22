/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange);
    }
    return array;
}

const int SIZE = 4;
const int LEFT = 0;
const int RIGHT = 11;

int[] massive = GetRandomArray(SIZE, LEFT, RIGHT);
Console.WriteLine(string.Join(", ", massive));

// Сложение чисел на нечетных позициях:
int Addition(int[] array)
{
    int result = 0;
    for (int i = 1; i < massive.Length; i = i + 2)
    {
        result = result + massive[i];
    }
    return result;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях по индексу: {Addition(array: massive)}");