// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Fill2DArr(M, N, -10, 10);

Console.WriteLine("Исходный массив : ");
PrintArray(array); // Вызов метода печати массива
// SummArrayDiagonal(array); // Вызов метода преобразованного массива
Console.WriteLine("сумма главной диагонали массива : ");
SummArrayDiagonal(array); // Вызов метода преобразованного массива
// PrintArray(array); // Вызов метода печати массива

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

// Метод суммы главной диагонали
void SummArrayDiagonal(int[,] array)
{
   int  summIJ=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             if (i==j)
             {
               
                summIJ =(summIJ+ array[i, j]);
             }
            
            //  Console.Write(array[i, j] + " ");
        }
        
         
    }
   Console.WriteLine(summIJ);
return;
}
