//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("введите число ");
int num = int.Parse(Console.ReadLine());
int B=1;
if(num<1)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}

while (B<=num)
{
    if (B % 2==0)
    {
       Console.Write($"{B} ");
    }
    B++;
}



