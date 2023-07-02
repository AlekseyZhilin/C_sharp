// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrix(int row, int column){
    double[,] matrix = new double[row, column];
    for (int i=0; i < row; i++){
        for (int j=0; j < column; j++) matrix[i, j] = Math.Round(Random.Shared.NextDouble(), 2);
    }

    return matrix;
}

void PrintMatrix(double[,] matrix){
    for (int i=0; i < matrix.GetLength(0); i++){
        for (int j=0; j < matrix.GetLength(1); j++) 
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

double[,] myMatrix = CreateMatrix(row, column);
PrintMatrix(myMatrix);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

Console.WriteLine("Введите номер строки:");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int columnNumber = Convert.ToInt32(Console.ReadLine());

double ArgumentValue(int rowPos, int columnPos){
    if (rowPos > myMatrix.GetLength(0) || columnPos > myMatrix.GetLength(1)){
        Console.WriteLine("Неверный индекс элемента");
        return 0;
    } 
    return myMatrix[rowPos - 1, columnPos - 1];

}

double elem = ArgumentValue(rowNumber, columnNumber);
if (elem !=0)
    Console.WriteLine($"Искомый элемент {elem}");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

double[] ColumnMean(){
    double[] meanArray = new double[myMatrix.GetLength(1)];
    for (int i=0; i < myMatrix.GetLength(0); i++){
        for (int j=0; j < myMatrix.GetLength(1); j++) 
            meanArray[j] += (myMatrix[i, j]);
    }

    int countInColumns = myMatrix.GetLength(0);
    for (int i=0; i < myMatrix.GetLength(1); i++)
        meanArray[i] = Math.Round(meanArray[i] / countInColumns, 2);

    return meanArray;
}

Console.WriteLine("Среднее арифметическое по столбцам:");
Console.WriteLine(string.Join(", ", ColumnMean()));