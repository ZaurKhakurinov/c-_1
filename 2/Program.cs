// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"большее значение {a}, меньшее {b}");
}else
{
    Console.WriteLine($"большее значение {b}, меньшее {a}");
}