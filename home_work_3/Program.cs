//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
int dig = 5;
Console.WriteLine("Введите пятизначное число");
int IntVal = Convert.ToInt32(Console.ReadLine());

if(IntVal / Pow10(dig - 1) > 0 && IntVal / Pow10(dig - 1) < 10){
    if(IsPalindrom(IntVal, dig)) Console.WriteLine("Число палиндром");
    else Console.WriteLine("Число не палиндром");
}
else Console.WriteLine("Число не пятизначное");

int Pow10(int exp){
    int res = 1;

    while (exp > 0){
        res *= 10;
        exp -= 1;
    }
    return res;
}

bool IsPalindrom(int val, int dig){
    int cur_iter = 0;
    bool res = true;
    int [] ValDigit = new int[5];
    while (cur_iter < dig){
        ValDigit[cur_iter] = (val % Pow10(cur_iter + 1) / Pow10(cur_iter));
        cur_iter += 1;
    }

    for(int i = 0; i < dig / 2; i++){
        if(ValDigit[i] != ValDigit[dig - 1 - i]){
            res = false;
            break;
        }
    }
    
    return res;
}

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("введите x1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y1");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z1:");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите x2:");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y2");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z2:");
int Z2 = Convert.ToInt32(Console.ReadLine());
double res = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
Console.WriteLine("расстояние в трёхмерном пространстве: " + res);

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("введите число:");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=N; i++){
    Console.WriteLine(i + "-" + Math.Pow(i, 3));
}