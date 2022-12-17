// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrix1 = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] result = new int[2, 2];
for (int i = 0; i < 2; i++)
  {
     for (int j = 0; j < 2; j++)
      {
          matrix1[i, j] = new Random().Next(1, 10);
          matrix2[i, j] = new Random().Next(1, 10);
      }
      Console.WriteLine();
  }
Console.WriteLine("Матрица 1: ");
PrintArray(matrix1);
Console.WriteLine("Матрица 2: ");
PrintArray(matrix2);

for (int i = 0; i < 2; i++)
  {
      for (int j = 0; j < 2; j++)
      {
          for (int k = 0; k < 2; k++)
          {
              result[i, j] = result[i, j] + (matrix1[i, k] * matrix2[k, j]);
          }
      }
  }
Console.WriteLine(" Результирующая матрица: ");

PrintArray(result);

int[,] PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

