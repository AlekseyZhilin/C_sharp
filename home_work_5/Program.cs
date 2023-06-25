// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = new int[4];

void GetNextValArray(){
    for(int i = 0; i < array.Length; i++) 
        array[i] = Random.Shared.Next(100, 1000);
}
int CountChetValues(){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) count++;
    }

    return count;
}

GetNextValArray();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество чётных элементов = {CountChetValues()}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array36 = new int[7];
void GetNextVal(){
    for(int i = 0; i < array36.Length; i++) 
        array36[i] = Random.Shared.Next(0, 1000);
}

int SumChetValues(){
    int sum = 0;
    for(int i = 1; i < array36.Length; i++){
        if(i % 2 == 1) sum +=array36[i];
    }
    return sum;
}

GetNextVal();
Console.WriteLine(string.Join(", ", array36));
Console.WriteLine($"Сумма чётных элементов = {SumChetValues()}");
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array38 = new double[7];
void GetNextDouble(){
    int val = 0;
    for(int i = 0; i < array38.Length; i++){
        val = Random.Shared.Next(1, 100);
        array38[i] = val + Math.Round(Random.Shared.NextDouble(), 2);
    }
}

double MinValueArray(){
    double minVal = array38[0];
    for(int i = 1; i < array38.Length; i++){
        if(array38[i] < minVal) minVal = array38[i];
    }

    return minVal;
}

double MaxValueArray(){
    double maxVal = array38[0];
    for(int i = 1; i < array38.Length; i++){
        if(array38[i] > maxVal) maxVal = array38[i];
    }

    return maxVal;
}

GetNextDouble();
Console.WriteLine(string.Join(", ", array38));
double minVal = MinValueArray();
double maxVal = MaxValueArray();
Console.WriteLine($"Минимальное значение в массиве = {minVal}");
Console.WriteLine($"Максимальное значение в  массвие = {maxVal}");
Math.Round(maxVal - minVal, 2);
Console.WriteLine($"Разница менжу значениями = {Math.Round(maxVal - minVal, 2)}");