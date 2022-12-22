/*
 * Задача 34 
 * Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 */

Random random = new Random();
int[] numbers = new int[random.Next(4,10)];
int count = 0;
for(int i = 0; i < numbers.Length; i++){
    numbers[i] = random.Next(100,1000);
    if(numbers[i]%2 == 0) count++;
}
Console.WriteLine($"Массив: [{string.Join(',',numbers)}]");
Console.WriteLine($"Количество четных чисел: {count}");