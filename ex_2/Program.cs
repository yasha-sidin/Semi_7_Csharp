// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Заполнить двумерный массив, где каждый элемент равен сумме разрядностей
int[,] FillIntPlusBitsTableArray(int[,] tableArray)
{
    for(int i = 0; i < tableArray.GetLength(0); i++)
    {
        for(int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i, j] = i + j;
        }
    }

    return tableArray;
}

// -----------------------------------------------------------------------------------------

// Напечатать двумерный массив
void PrintIntTableArray(int[,] tableArray)
{
    for(int i = 0; i < tableArray.GetLength(0); i++)
    {
        for(int j = 0; j < tableArray.GetLength(1); j++)
        {
            Console.Write($"{tableArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// -----------------------------------------------------------------------------------------

Console.Write("Количество строк массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов массива (m): ");
int n = int.Parse(Console.ReadLine());

int[,] tableArray = new int[m, n];

FillIntPlusBitsTableArray(tableArray);
PrintIntTableArray(tableArray);