//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Введите количество столбцов матрицы: ");
int inputM = GetInput();
Console.WriteLine("Введите количество строк матрицы: ");
int inputN = GetInput();
int[,] array = new int[inputN, inputM];
GetArray(inputM, inputN);
PrintArray(array);
Console.WriteLine("Введите номер строки возврата: ");
int getM = GetInput();
Console.WriteLine("Введите номер столбца возврата: ");
int getN = GetInput();
GetElemetnArray(array, getM, getN);


int GetInput()
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
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}

void PrintArray(int[,] array)
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

void GetElemetnArray(int[,] array, int getM, int getN)
{
if (getN <= array.GetLength(0) && getM <= array.GetLength(1) && getN > 0 && getM > 0)
{
    Console.WriteLine($"Элемент матрицы [{getM}, {getN}] = {array[getN - 1, getM - 1]}");
}
else 
{
    Console.WriteLine("Такой позиции в матрице нет");
}
}