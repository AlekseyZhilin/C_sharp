// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите число для цикла:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int val = 0;
for(int i = 0; i < number; i++){
    Console.WriteLine($"Введите {i + 1} число:");
    val = Convert.ToInt32(Console.ReadLine());
    if(val > 0) count++;
}
Console.WriteLine($"Количество чисел больше 0 - {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения прямых x,y ({Math.Round(x, 2)}, {Math.Round(y, 2)})");

