// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("---Задача 2---");
Console.WriteLine("Введите первое число");
string? numb1String = Console.ReadLine()!;
int numb1 = Convert.ToInt32(numb1String);
Console.WriteLine("Введите второе число");
string? numb2String = Console.ReadLine()!;
int numb2 = Convert.ToInt32(numb2String);

if (numb1 > numb2){
    Console.WriteLine("Первое число больше второго");
}
if (numb1 < numb2){
    Console.WriteLine("Второе число больше первого");
}
if (numb1 == numb2){
    Console.WriteLine("Числа равны");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("---Задача 4---");
Console.WriteLine("Введите первое число");
string? numb1_4String = Console.ReadLine()!;
int numb1_4 = Convert.ToInt32(numb1_4String);

Console.WriteLine("Введите второе число");
string? numb2_4String = Console.ReadLine()!;
int numb2_4 = Convert.ToInt32(numb2_4String);

Console.WriteLine("Введите третье число");
string? numb3_4String = Console.ReadLine()!;
int numb3_4 = Convert.ToInt32(numb3_4String);

int maxVal = numb1_4;
if (numb2_4 > maxVal){
    maxVal = numb2_4;
}
if (numb3_4 > maxVal){
    maxVal = numb3_4;
}
Console.WriteLine("Максимальное число:");
Console.WriteLine(maxVal);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("---Задача 6---");
Console.WriteLine("Введите число");
string? numbString = Console.ReadLine()!;
int numb = Convert.ToInt32(numbString);
if (numb % 2 == 0){
    Console.WriteLine("Число чётное");
}
else{
    Console.WriteLine("Число не чётное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("---Задача 8---");
Console.WriteLine("Введите число");
string? NString = Console.ReadLine()!;
int N = Convert.ToInt32(NString);
if(N > 0){
    Console.WriteLine("Чётные числа:");
    for (int i = 1; i <= N; i++){
        if(i % 2 == 0){
            Console.WriteLine(i);
        }
    }
}
else{
    Console.WriteLine("Число должно быть положительным");
}