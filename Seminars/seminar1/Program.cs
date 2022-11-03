/*

Console.Write("Input first number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"My first number is {num}");
*/



// Здесь я вывожу мое первое число
// Задание 1. Напишите программу, которая на вхjд принимает число и выдает его квадрат (число умноженное на само себя).

//**Например:**

//4 -> 16
//-3 -> 9 
//-7 -> 49
/*
Console.WriteLine("input number ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine($"Quad of {num} is -> {result}");
*/




// написать программу которая показывает все числа от -N до +N
/*
Console.WriteLine("input number ");
int num = Convert.ToInt32 (Console.ReadLine());
int current = num * (-1);
while (current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

// Написать программу которая показывает последнюю цифру трехзначного числа
/*
Console.WriteLine("input number ");
int num = Convert.ToInt32 (Console.ReadLine());
int current = num % 10;
Console.Write(current);
*/




Console.WriteLine("input first number ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("input srcond number ");
int num2 = Convert.ToInt32 (Console.ReadLine());
int quad2 = num2 * num2;
if (num1 == quad2)
    Console.WriteLine($"{num1} является квадратом {num2}");
else Console.WriteLine($"{num1} не является квадратом {num2}");