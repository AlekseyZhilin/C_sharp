int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);

void ConvertToArray(double val){
    double inputVal = val;
    int exp = 2;
    int intDigit = Convert.ToInt32(inputVal);
    if(inputVal < intDigit) intDigit -= 1;

    Console.WriteLine("Целое число: " + intDigit);

    inputVal -= intDigit;
    for(int i = 1; i <= exp; i++){
        inputVal *= 10;
    }
    int mantisVal = Convert.ToInt32(inputVal);
    int firstDigit = mantisVal / 10;
    int lastDigit = mantisVal % 10;
    Console.WriteLine("Первый разряд: " + firstDigit);
    Console.WriteLine("Второй разряд: " + lastDigit);
}

ConvertToArray(3.12);
ConvertToArray(7.81);
