// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// МАССИВ НАЧИНАЕТСЯ С 0!!!!!!!!!!!!!!
Console.WriteLine("Сколько чисел в массиве нужно?");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Создал для Вас массив: ");
PrintArray(numbers);
int sum = 0;

for (int num = 1; num < numbers.Length; num+=2)
    sum = sum + numbers[num];

    Console.WriteLine($"В массиве {numbers.Length} числа, сумма элементов, стоящих на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}