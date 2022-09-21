// 7. Напишите программу, которая принимает 
// на вход трехначное число и на выходе показывает последнюю цифру этого числа

// 456 -> 6
// 782 -> 2

Console.WriteLine("Введите трехначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
int res = num % 10;
Console.Write($"{num} -> {res}");
}
else
{
Console.Write("Неверное число");
}