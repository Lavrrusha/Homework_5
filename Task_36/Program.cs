/*
 * Задача 36
 * Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 */

Random random = new Random();
int[] numbers = new int[random.Next(4,10)];
int sum = 0;
for(int i = 0; i < numbers.Length; i++){
    numbers[i] = random.Next(1,50);
    if(i%2 != 0) sum+=numbers[i];
}
Console.WriteLine($"Массив: [{string.Join(',',numbers)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");