﻿// Написать программу которая принимает на вход число и проверяет является ли оно четным
Console.Clear();
Console.Write("введите число ");
int num = int.Parse(Console.ReadLine());
if (num % 2==1)
{
    Console.WriteLine($"значение {num} не четное");
}else
{
    Console.WriteLine($"значение {num} четное");
}  
        
// Не понятно почему в if (num % 2==1) - 1 является ложью, хотя должно быть наоборот. Или я что то не так понял?