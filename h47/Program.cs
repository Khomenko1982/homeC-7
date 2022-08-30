// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

double[,] array = Fill2DArr(M, N, -10, 10);

PrintArray(array); // Вызов метода печати массива


// Метод возвращает двумерный вещественный массив [,] на size элементов 
double[,] Fill2DArr(int rowsCount, int columnsCount, double lefts, double rights)
{
    double[,] array = new double[rowsCount, columnsCount];

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = random.NextDouble() * 10; 
        }
    }
    {

    }
    return array;
}
// Метод печати двумерного массива
void PrintArray(Double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5:F1}",array[i, j]);
                   }
        Console.WriteLine();
    }

}