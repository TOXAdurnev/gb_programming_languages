// 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет

Console.WriteLine("Введите первое  число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int square = b * b;
if (square == a)
{
 Console.Write($"a = {a}, b = {b} -> да");   
}
else
{
Console.Write($"a = {a}, b = {b} -> нет"); 
}