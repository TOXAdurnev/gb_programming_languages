// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//Решение:
Console.WriteLine("Введите первое  число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
 Console.Write($"a = {a}, b = {b}, c = {c} -> max = {a}");   
}
if (b > a && b > c)
{
 Console.Write($"a = {a}, b = {b}, c = {c} -> max = {b}");   
}
if (c > a && c > b)
{
 Console.Write($"a = {a}, b = {b}, c = {c} -> max = {c}");   
}
if (a == b && a > c)
{
 Console.Write($"a = {a}, b = {b}, c = {c} -> max = {a}");   
}
if (a == c && a > b)
{
 Console.Write($"a = {a}, b = {b}, c = {c} -> max = {a}");   
}
if (b == c && b > a)
{
 Console.Write($"a = {a}, b = {b}, c = {c} -> max = {b}");   
}
if(b == c && b == a)
{
 Console.Write($"a = {a}, b = {b}, c = {c} -> Все числа равны");   
}