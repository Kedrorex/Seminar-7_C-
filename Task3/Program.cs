// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.

int[,] FillMatrixWithRandom(int row, int column)
{
  int[,] matrix = new int[row, column];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(0, 10);
    }
  }
  return matrix;
}

int[,] GetMatrixQvadart(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i % 2 == 0 && j % 2 == 0)
        matrix[i, j] = matrix[i, j] * matrix[i, j];
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      System.Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine();
matrix = GetMatrixQvadart(matrix);
PrintMatrix(matrix);