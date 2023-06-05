// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[,]{ { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int rows = array.GetLength(0);
int cols = array.GetLength(1);

for (int i = 0; i < cols; i++)
{
    int sum = 0;
    for (int j = 0; j < rows; j++)
    {
        sum += array[j, i];
    }
    double average = (double)sum / rows;
    Console.WriteLine("Среднее арифметическое в столбце {0}: {1}", i, average);
}