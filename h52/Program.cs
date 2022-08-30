// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, -10, 10);
Console.WriteLine("Исходный массив : ");
PrintArray(array); // Вызов метода печати массива
PrintAverageMath(array);


// Метод возвращает двумерный массив [,] на size элементов 
int[,] Fill2DArr(int rowsCount, int columnsCount, int lefts, int rights)
{
    int[,] array = new int[rowsCount, columnsCount];

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(lefts, rights);
        }
    }
    {

    }
    return array;
}
// Метод печати двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

// Метод печати среднего арифметического столбцов массива
void PrintAverageMath(int[,] array)
{
    int[] averageMath=new int[N];
         for (int i = 0; i < array.GetLength(0); i++)
     {
        for (int j = 0; j < array.GetLength(1); j++)
        {
   
//    averageMath[i]+=array[j,i];
   averageMath[j]+=array[i,j];
        }
      
     }
      Console.Write("Среднее арифметическое каждого столбца: ");
      foreach (double elem in averageMath)
              Console.Write(elem/M + " ");
return;
}