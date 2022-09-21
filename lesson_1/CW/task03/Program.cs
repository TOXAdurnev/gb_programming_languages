// 3. Напишите программу, которая будет 
// выдавать название недели по заданному номеру
// 3  -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 && a < 8)
{
if (a == 1 )
{
Console.Write($"{a}  -> Понедельник"); 
}
if (a == 2 )
{
Console.Write($"{a}  -> Вторник"); 
}
if (a == 3 )
{
Console.Write($"{a}  -> Среда"); 
}
if (a == 4 )
{
Console.Write($"{a}  -> Четверг"); 
}
if (a == 5 )
{
Console.Write($"{a}  -> Пятница"); 
}
if (a == 6 )
{
Console.Write($"{a}  -> Суббота"); 
}
if (a == 7 )
{
Console.Write($"{a}  -> Воскресенье"); 
} 
}
else
{
Console.Write("Такого дня не существет, в недели 7 дней");   
}