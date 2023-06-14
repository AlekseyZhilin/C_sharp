//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Задача 10");
int inputVal = Random.Shared.Next(100, 1000);
Console.WriteLine("Сгенерированное число: " + inputVal);
int  firstDigit = inputVal / 100;
Console.WriteLine("Первый разряд: " + firstDigit);
int lastdigit = inputVal % 10;
Console.WriteLine("Последний разряд: " + lastdigit);
int midDigit = (inputVal - 100 * firstDigit - lastdigit) / 10;
Console.WriteLine("Ответ");
Console.WriteLine("Средний разряд: " + midDigit);


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Задача 13");
int inputVal_13 = Random.Shared.Next(0, 1000);
Console.WriteLine("Сгенерированное число: " + inputVal_13);
int exp = 1;
int curVal = inputVal_13;
while(true){
    curVal = curVal / 10;
    if(curVal > 0) exp++;
    if((curVal / 10)  == 0) break;
}
Console.WriteLine("Разрядность числа: " + exp);
if(exp == 3){
    Console.WriteLine("Третий разряд: " + inputVal_13 % 10);
}
else{
    Console.WriteLine("Нет третьего разряда");
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Задача 15");
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 6 || day == 7){
    Console.WriteLine("Выходной день");
}
else if(day > 0 && day < 6){
    Console.WriteLine("Не выходной день");
}
else{
    Console.WriteLine("Такого дня не существует");
}