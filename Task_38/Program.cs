/*
 * Задача 38
 * Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 */

Random random = new Random();
double[] numbers = new double[random.Next(4, 10)];
double max = 0;
double min = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Math.Round(random.NextDouble() * (100 - 1) + 1,2);
    if (i != 0)
    {
        if (numbers[i] > max)
            max = numbers[i];
        if (numbers[i] < min)
            min = numbers[i];
    }
    else
    {
        max = numbers[0];
        min = numbers[0];
    }
}
Console.WriteLine($"Массив: [{string.Join('|', numbers)}]");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");