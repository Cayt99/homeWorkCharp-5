﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0 

// Создание массива и заполнение случайными числами
int[] array = new int[4];
Random random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-100, 100); // Генерация случайного числа от -100 до 100
}

// Вычисление суммы элементов на нечетных позициях
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) // Проверка, что позиция нечетная
    {
        sum += array[i];
    }
}

// Вывод результатов
Console.WriteLine("Массив: " + string.Join(", ", array));
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);