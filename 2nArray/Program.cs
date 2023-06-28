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

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Difference(int number){
    int delit = number / 2;
    Console.WriteLine(number - delit * 2);
    if(delit != 0) return Difference(delit);
    return -1;
}

Difference(number);
Console.WriteLine();

double resLog = Math.Log2(number);
int digits = Convert.ToInt32(resLog);
// if(resLog != Convert.ToInt32(resLog)) digits ++;
digits++;

int curPos = 0;
int [] binVal = new int[digits];
while(number != 0){
    binVal[digits - curPos - 1] = number % 2;
    number /= 2;
    curPos++;
}
Console.WriteLine($"[ {string.Join(" ", binVal)} ]");