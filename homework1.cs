//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 

Console.WriteLine("Введите количество столбцов матрицы: ");
int inputM = GetIntInput();
Console.WriteLine("Введите строк матрицы: ");
int inputN = GetIntInput();
double[,] array = new double[inputN, inputM];
GetArray(inputM, inputN);
PrintArray(array);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void GetArray(int inputM, int inputN)
{
    for (int i = 0; i < inputN; i++)
    {
        for (int j = 0; j < inputM; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
            array[i, j] = Math.Round(array[i, j], 1);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (j == array.GetLength(1) - 1)
           {
                Console.Write($"{array[i, j]} ");
           }
           else 
           {
                Console.Write($"{array[i, j]}, ");
           }
        }
        Console.WriteLine("");
    }
}
