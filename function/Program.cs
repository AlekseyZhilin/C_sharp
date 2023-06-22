// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// while(true){
//     Console.WriteLine("1");
// }

for(int i = 2; i < 10; i++){
    for(int j = 1; j < 10; j++){
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine("");
}


for(int i = 1; i < 10; i++){
    Console.Write($"{i}, ");
}
Console.WriteLine();