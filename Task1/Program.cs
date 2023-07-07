// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] numbers = GenerateRandomNumbers(4); // Задайте здесь размер массива

Console.WriteLine("Сгенерированный массив:");
PrintArray(numbers);

int evenCount = CountEvenNumbers(numbers);

Console.WriteLine("Количество четных чисел в массиве: " + evenCount);

static int[] GenerateRandomNumbers(int size)
{
    Random random = new Random();
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(100, 1000); // Генерация случайного трехзначного числа
    }

    return numbers;
}

static void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

static int CountEvenNumbers(int[] array)
{
    int count = 0;

    foreach (int num in array)
    {
        if (num % 2 == 0) // Проверка на четность
        {
            count++;
        }
    }

    return count;
}

