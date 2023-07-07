// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//  Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("---Задача 54---");
Console.WriteLine();

int[,] CreateMatrix(int rows, int columns){
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            matrix[i, j] = Random.Shared.Next(0, 10);

    return matrix;
}

void PrintMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++) 
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }

}

int[] BableSortedArray(int[] sortArray){
    int lenArray = sortArray.Length;
    int[] myArray = new int[lenArray];
    for (int i = 0; i < lenArray; i++)
        myArray[i] = sortArray[i];

    int temp = 0;
    for (int i = 0; i < lenArray; i++)
        for (int j = 1; j < lenArray; j++)
            if (myArray[j - 1] < myArray[j]){
                temp = myArray[j - 1];
                myArray[j - 1] = myArray[j];
                myArray[j] = temp;
            }       

    return myArray;
}

int[,] SortedByDescendingMatrix(int[,] matrix){
    int rowsMatrix = matrix.GetLength(0);
    int columnsMatrix = matrix.GetLength(1);
    int[,] sortedMatrix = new int[rowsMatrix, columnsMatrix];
    for (int i = 0; i < rowsMatrix; i++){
        int[] rowArray = new int[columnsMatrix];
        for (int elem = 0; elem < columnsMatrix; elem++)
            rowArray[elem] = matrix[i, elem];
        rowArray = BableSortedArray(rowArray);
        for (int j = 0; j < columnsMatrix; j++)
            sortedMatrix[i, j] = rowArray[j];
    }

    return sortedMatrix;
}

int[,] myMatrix = CreateMatrix(4, 5);
PrintMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(SortedByDescendingMatrix(myMatrix));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine();
Console.WriteLine("---Задача 56---");
Console.WriteLine();

int MinSumRowinArray(int[,] matrix){
    int rowSum = 0;
    int minSum = 0;
    int index = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++){
        rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++){
            rowSum += matrix[i, j];
        }
        
        if (i == 0){
            minSum = rowSum;
            index = 0;
        }
        else if (rowSum < minSum){
            minSum = rowSum;
            index = i;
        }
    }

    return index;
}

Console.WriteLine($"Строка с минимальным индексом {MinSumRowinArray(myMatrix)}");

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

Console.WriteLine();
Console.WriteLine("---Задача 58---");
Console.WriteLine();

int[,] matrix1 = CreateMatrix(2, 2);
int[,] matrix2 = CreateMatrix(2, 2);

int[,] MulMatrix(int[,] matrix1, int[,] matrix2){
    int rows = matrix1.GetLength(0);
    int columns = matrix1.GetLength(1);
    int[,] mulMatrix = new int[rows, columns];

    if (rows == matrix2.GetLength(0) && columns == matrix2.GetLength(1)){
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            mulMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
    }
    return mulMatrix;
}

PrintMatrix(MulMatrix(matrix1, matrix2));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine();
Console.WriteLine("---Задача 60---");
Console.WriteLine();

int[,,] TreeDimentionArray(int dim1, int dim2, int dim3){
    int[,,] matrix = new int[dim1, dim2, dim3];
    int firstValue = 10;
    int delta = 1;
    for (int i = 0; i < dim1; i++)
        for (int j = 0; j < dim2; j++)
            for (int k = 0; k < dim3; k++){
                matrix[i, j, k] = firstValue + delta;
                delta++;
            }

    return matrix;
}

void PrintTreeDimentionArray(int[,,] matrix){
    int dim1 = matrix.GetLength(0);
    int dim2 = matrix.GetLength(1);
    int dim3 = matrix.GetLength(2);
    for (int i = 0; i < dim1; i++)
        for (int j = 0; j < dim2; j++){
            for (int k = 0; k <dim3; k++){
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) | ");
            }
            Console.WriteLine();
        }
}

PrintTreeDimentionArray(TreeDimentionArray(3, 4, 3));

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine();
Console.WriteLine("---Задача 62---");
Console.WriteLine();

int[,] CreateSquereMatrix(int size){
    int[,] matrix = new int[size, size];
    int countSizeElement = 4;
    // подставил 10 вместо 1 для выравнивание квадратной матрицы.
    int firstElement = 10;
    int lastElement = firstElement + countSizeElement - 1;
    for (int i = 0; i < countSizeElement; i++){
        matrix[0, i] = firstElement + i;
    }
    countSizeElement--;
    firstElement = lastElement + 1;
    lastElement = firstElement + countSizeElement;

    for (int j = 0; j < countSizeElement; j++){
        matrix[j + size - countSizeElement, countSizeElement] = firstElement + j;
    }
    
    firstElement = lastElement + 1;
    lastElement = firstElement + countSizeElement - 2;

    for (int i = 0; i < countSizeElement; i++){
        matrix[size - 1, i] = lastElement - i;
    }

    firstElement = lastElement + 1;
    lastElement = firstElement + countSizeElement - 2;
    for (int j = 0; j < countSizeElement; j++){
        matrix[j + size - countSizeElement, 0] = lastElement - j;
    }

    countSizeElement--;
    firstElement = lastElement + 1;
    lastElement = firstElement + countSizeElement - 2;
    for (int i = 0; i < countSizeElement; i++){
        matrix[1, 1 + i] = firstElement + i;
    }

    firstElement = lastElement + 1;
    lastElement = firstElement + countSizeElement;
    for (int i = 0; i < countSizeElement; i++){
        matrix[2, 1 + i] = lastElement - i;
    }

    return matrix;
}

PrintMatrix(CreateSquereMatrix(4));