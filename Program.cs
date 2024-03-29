﻿/*
Задача 53: 
Задайте двумерный массив из целых чисел. 
Напишите программу, которая меняет местами первую и последнюю строку массива.
*/
// Метод для создания массива
// Двумерный массив = matrix
// m - количество строчек, n - количество столбцов

Console.Write("Введите количество строчек : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int maxElements = Convert.ToInt32(Console.ReadLine());

int[,] resMatrix = GetMatrix(rows, columns, minElements, maxElements);

// rows = 3 columns = 4 => таблица из 3-х строк и 4 -х столбцов, элемент: число от min до max включительно
Console.WriteLine();
PrintMatrix(resMatrix); // PrintMatrix(матрица)
Console.WriteLine();

ChangeRows(resMatrix); // Внутри resMatrix происходит замена первой и последней строчки
Console.WriteLine("Матрица результат: ");
PrintMatrix(resMatrix);

int[,] GetMatrix(int m, int n, int minElements, int maxElements)
{
    int[,] matrix = new int[m,n]; // Таблица из m - строк и n - столбцов
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам, i < m
    {
       // i, j, m, k
       for (int j = 0; j < matrix.GetLength(1); j++) // Цикл по столбцам, j < n
       {
        matrix[i, j] = new Random().Next(minElements, maxElements+1);
       } 
    }
    return matrix;
}
// Метод, который печатает массив
void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++) // строчки
    {
       for (int j = 0; j < array2D.GetLength(1); j++) // столбцы
       {
        Console.Write(array2D[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
       } 
       Console.WriteLine();
    }

}
// Метод, который меняет местами первую и последнюю строку массива.
void ChangeRows(int[,] array2D)
{
    int lastRowIndex = array2D.GetLength(0) -1; // Индекс последней строчки

    for (int i = 0; i < array2D.GetLength(1); i++)
    {
      int temp  = array2D [0, i];
      array2D [0, i] = array2D[lastRowIndex, i];
      array2D[lastRowIndex, i] = temp;
    }
}