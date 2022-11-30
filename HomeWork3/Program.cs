// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] >= max)
    {
        max = num[i];
    }
    else if (num[i] <= min)
    {
        min = num[i];
    }
}
Console.WriteLine($"Максимальное значение = {max} минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
void FillArrayRandomNumbers(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100, 1000) + new Random().NextDouble();
        num[i] = Math.Round(num[i], 2);
    }
}
