// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[,] array = new int[2, 4];

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i ++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);