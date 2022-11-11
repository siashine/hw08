// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// (посмотрите как реализуется произведение матриц, 
// там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// int[,] array = new int [2,2]{{2,4},{3,2}}; проверка.надо закомитить GetArray(array)
int[,] array = new int[2, 2];
GetArray(array);
PrintArray(array);

// int[,] array1 = new int [2,2]{{3,4},{3,3}}; проверка.надо закомитить GetArray(array1)
int[,] array1 = new int[2, 2];
GetArray(array1);
PrintArray(array1);

int[,] array2 = Method(array, array1);
PrintArray(array2);

void GetArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(0, 10);
    }
  }
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}

static int[,] Method(int[,] A, int[,] B)
{
  int[,] C = new int[A.GetLength(0), B.GetLength(1)];
  int sum = 0;
  int x = 0, y = 0, u = 0, j = 0;

  if (A.GetLength(1) == B.GetLength(0))
  {
    for (x = 0; x < A.GetLength(0); x++)
    {
      for (j = 0; j < B.GetLength(1); j++)
      {
        for (y = 0, u = 0, sum = 0; y < A.GetLength(1); y++, u++)
        {
          sum += A[x, y] * B[u, j];
        }
        C[x, j] = sum;
      }
    }
  }

  return C;
}