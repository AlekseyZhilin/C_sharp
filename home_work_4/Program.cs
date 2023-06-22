// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B:");
int B = Convert.ToInt32(Console.ReadLine());
int PowA(int A, int B){
    int res = 1;
    for(int i = 0; i < B; i++) {
        res *= A;
    }
    return res;
}
A = PowA(A, B);
Console.WriteLine("Число А в степени В = " + A);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число:");
int value = Convert.ToInt32(Console.ReadLine());
int SumDigit(int value){
    int res = 0;
    int digit = value;
    int count = 0;
    while(digit > 0){
        res += digit % 10;
        digit /= 10;
        count ++;
    }

    return res;
}
Console.WriteLine("Симма чисел = " + SumDigit(value));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] array = new int[8];
Console.WriteLine("введите верхний диапазон массива");
int upArray = Convert.ToInt32(Console.ReadLine());
void CreateArray(int upArray){
    for(int i = 0; i < array.Length; i++) array[i] = Random.Shared.Next(0, upArray);
}
void PrintArray(){
    Console.WriteLine("Массив:");
    for(int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
}

CreateArray(upArray);
PrintArray();