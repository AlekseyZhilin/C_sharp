// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.WriteLine("Введите число:");
string? numberString = Console.ReadLine()!;
int number = Convert.ToInt32(numberString);
Console.WriteLine(number * number);
if (number == 100){
    Console.WriteLine("число 100");
}
else{
    Console.WriteLine("число отличное от 100");
}

for(int i = -number; i <= number; i++){
    Console.WriteLine(i);
}
