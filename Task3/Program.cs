// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

double min = numbers[0]; // Предполагаем, что первый элемент является минимальным
double max = numbers[0]; // Предполагаем, что первый элемент является максимальным

// Находим минимальный и максимальный элементы массива
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }

    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

double difference = max - min;
Console.WriteLine($"[{string.Join(", ", numbers)}] => {max} - {min} = {difference}");

// Random random = new Random();
// double[] numbers = new double[5];

// // Заполняем массив случайными вещественными числами
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = random.NextDouble() * 100; // Генерируем случайное число от 0 до 100
// }

// double min = numbers[0]; // Предполагаем, что первый элемент является минимальным
// double max = numbers[0]; // Предполагаем, что первый элемент является максимальным

// // Находим минимальный и максимальный элементы массива
// for (int i = 1; i < numbers.Length; i++)
// {
//     if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }

//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
// }

// double difference = max - min;
// Console.WriteLine($"[{string.Join(", ", numbers)}] => {max} - {min} = {difference}");
