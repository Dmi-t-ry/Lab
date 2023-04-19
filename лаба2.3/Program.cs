int x = 11, y = 4;
float z = 4;
Console.WriteLine(z * y);             // Результат 16
Console.WriteLine(z * 1e308);     // Рез. "бесконечность"
Console.WriteLine(x / y);             // Результат 2
Console.WriteLine(x / z);             // Результат 2,75
Console.WriteLine(x % y);             // Результат 3
Console.WriteLine(1e-324 / 1e-324);   // Результат NaN
Console.ReadKey();
