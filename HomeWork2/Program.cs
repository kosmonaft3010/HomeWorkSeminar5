// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
int sum = 0;
int[] GetArray(int[] arrya)
{
    for (int i = 0; i < arrya.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
        if (array[i] % 2 != 0)
        {
            sum += array[i];
        }
    }
    return array;
}
GetArray(array);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("Cумму элементов, стоящих на нечётных позициях равна " + sum);
