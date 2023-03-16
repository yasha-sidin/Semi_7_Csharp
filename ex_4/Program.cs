// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на диагонали массива.

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

// Сумма элементов, находящихся на диагонали двумерного массива
int GetSumElementsFromDiagonaleTableArray(int[,] tableArray)
{
    int sum = 0;
    for(int i = 0; i < tableArray.GetLength(0); i++)
    {
        for(int j = 0; j < tableArray.GetLength(1); j++)
        {
            if(i == j)
            {
                sum += tableArray[i, j];
            }
        }
    }

    return sum;
}

// -----------------------------------------------------------------------------------------

Console.Clear();
Console.Write("Количество строк массива (m): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов массива (m): ");
int n = int.Parse(Console.ReadLine());

int[,] tableArray = new int[m, n];

FillIntTableArray(tableArray, 2, 20);
PrintIntTableArray(tableArray);

int sum = GetSumElementsFromDiagonaleTableArray(tableArray);
Console.WriteLine($"Сумма элементов диагонали = {sum}");