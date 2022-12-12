// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] array = GetSpiral(4);
PrintArray(array);

int[,] GetSpiral(int n)
{
    int[,] array = new int[4, 4];
    int startValue = 1;
    for (int i = 1; i < 4; i++)
    {
        for (int j = i - 1; j < 4 - i + 1; j++)
        {
            array[i - 1, j] = startValue++;
        }
        for (int j = i; j < 4 - i + 1; j++)
        {
            array[j, 4 - i] = startValue++;
        }
        for (int j = 4 - i - 1; j >= i - 1; j--)
        {
            array[4 - i, j] = startValue++;
        }
        for (int j = 4 - i - 1; j >= i; j--)
        {
            array[j, i - 1] = startValue++;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
}
