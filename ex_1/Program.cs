// Задача 46: Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Напечатать двумерный массив
void PrintIntTableArray(int[,] tableArray)
{
    for(int i = 0; i < tableArray.GetLength(0); i++)
    {
        for(int j = 0; j < tableArray.GetLength(1); j++)
        {
            if(j == tableArray.GetLength(1) - 1)
            {
                Console.WriteLine($"{tableArray[i, j]}");
                break;
            }
            Console.Write($"{tableArray[i, j]}, ");
        }
    }
}

// -----------------------------------------------------------------------------------------

// Заполнить двумерный массив случайными числами
int[,] FillIntTableArray(int[,] tableArray, int startRange, int endRange)
{
    for(int i = 0; i < tableArray.GetLength(0); i++)
    {
        for(int j = 0; j < tableArray.GetLength(1); j++)
        {
            tableArray[i, j] = new Random().Next(startRange, endRange + 1);
        }
    }

    return tableArray;
}

// -----------------------------------------------------------------------------------------

Console.Clear();
Console.Write("Количество строк массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов массива (m): ");
int n = int.Parse(Console.ReadLine());

int[,] tableArray = new int[m, n];

FillIntTableArray(tableArray, 0, 1);
PrintIntTableArray(tableArray);