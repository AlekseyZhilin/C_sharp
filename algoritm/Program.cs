/*
сложность - количество действий, которое необходимо выполнить для получения конечного результата
big O natation

---Константный алгоритм---
сложность алгоритма не зависит от введённого числа
сумма чисел от 1 до n
сложность O(1)
*/
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел = {(1 + number) / 2.0 * number}");

/*
---Линейный алгоритм---
сумма чисел от 1 до n (та же задача)
реализация - цикл
какое число введёт пользователь,столько раз выполниться алгоритм
сложность O(n)

*/
int result = 0;
for (int i = 0; i <= number; i++){
    result += i;
}
Console.WriteLine($"Сумма чисел = {result}");

/*
---Квадратичные---
сортировка пузырьком, вставками
реализация - цикл внутри другого цикла
О(n^2)
*/


/*
---Логарифмический---
бинарный поиск - делим пополам интервал поиска
сложность О(log2(n))
*/
Console.WriteLine("Введите искомое число:");
int findeNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите границу диапазона:");
int boundNumber = int.Parse(Console.ReadLine()!);

int BinSearch(int findeNumber, int boundNumber){
    int firstNumber = 0;
    int secondNumber = boundNumber;
    int halfNumber = 0;
    int curIteration = 0;

    while (true){
        curIteration++;
        halfNumber = (firstNumber + secondNumber) / 2;

        if (halfNumber == findeNumber)
            break;
        else if (halfNumber < findeNumber)
            firstNumber = halfNumber;
        else if (halfNumber > findeNumber)
            secondNumber = halfNumber;
    }
    Console.WriteLine($"Количество итераций - {curIteration}");
    return halfNumber;
}

if (findeNumber < boundNumber)
    Console.WriteLine($"Искомое число - {BinSearch(findeNumber, boundNumber)}");

Console.WriteLine();
for (int i = 1; i < 10; i++)
    Console.WriteLine($"Искомое число - {BinSearch(i, 10)}");

/*
--Линейно-логарифмический
сложность О(n * log2(n))

*/