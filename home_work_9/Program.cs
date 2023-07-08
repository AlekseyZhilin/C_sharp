// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("---Задача 64---");
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
void PrintNaruralValues(int number, int cur = 1){
    if (number < cur) return;
    PrintNaruralValues(number, cur + 1);
    Console.Write($"{cur}, ");
}

PrintNaruralValues(number);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine();
Console.WriteLine("---Задача 66---");
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int SumNaturalValues(int m, int n){
    if (m > n) return 0;
    return SumNaturalValues(m + 1, n) + m;
}

Console.WriteLine($"Сумма чисел от {m} до {n} = {SumNaturalValues(m, n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine();
Console.WriteLine("---Задача 68---");
Console.WriteLine("Введите число m:");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n1 = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n){
    if (m == 0) 
        return n + 1;
    else if (m > 0 && n ==0) 
        return Akkerman(m - 1, 1);
    //else if (m > 0 && n > 0)
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine(Akkerman(m1, n1));