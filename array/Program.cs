// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void FillArray(int[] collection){
    int len = collection.Length;
    int index = 0;
    while(index < len){
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection){
    int len = collection.Length;
    int index = 0;
    while(index < len){
        Console.WriteLine(collection[index]);
        index++;
    }
}

int IndexOfArray(int[] collection, int indOf){
    int len = collection.Length;
    int index = 0;
    int result = -1;
    while(index < len){
        if(collection[index] == indOf){
            result = index;
            break;
        }
        index++;
    }
    return result;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine("---");
Console.WriteLine(IndexOfArray(array, 2));

