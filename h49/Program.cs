// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, -10, 10);
Console.WriteLine("Исходный массив : ");
PrintArray(array); // Вызов метода печати массива
Print2Array(array); // Вызов метода преобразованного массива
Console.WriteLine("Преобразованный массив : ");
PrintArray(array); // Вызов метода печати массива

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
// Матод печати двумерного массива
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

// Матод печати двумерного массива
void Print2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i=i+2)
    {
        for (int j = 0; j < array.GetLength(1); j=j+2)
        {
            // if (((i)%2==0) && ((j)%2==0))
            // {
array[i, j] =(array[i, j]*array[i, j]);
            // }
            // Console.Write(array[i, j] + " ");
        }
        // Console.WriteLine();
    }
return;
}
