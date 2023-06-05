// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] array = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.WriteLine("Введите значение элемента: ");
int value = Convert.ToInt32(Console.ReadLine());
int row = -1;
int column = -1;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == value)
        {
            row = i;
            column = j;
            break;
        }
    }
}
if (row != -1 && column != -1)
{
    Console.WriteLine($"Позиция элемента: [{row},{column}]");
}
else
{
    Console.WriteLine("Такого элемента нет в массиве.");
}