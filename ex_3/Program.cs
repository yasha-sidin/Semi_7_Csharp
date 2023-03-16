// Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.

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

// Замена элементов с четными  индексами на их квадраты

int[,] GetSqrEvenElementsInTableArray(int[,] tableArray)
{
    for(int i = 0; i < tableArray.GetLength(0); i++)
    {
        for(int j = 0; j < tableArray.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0)
            {
                tableArray[i, j] *= tableArray[i, j];
            }
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

FillIntTableArray(tableArray, 2, 20);
PrintIntTableArray(tableArray);

Console.WriteLine();

GetSqrEvenElementsInTableArray(tableArray);
PrintIntTableArray(tableArray);

