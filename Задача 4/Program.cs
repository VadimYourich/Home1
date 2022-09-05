// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberB > numberA)
{
    if(numberC > numberB)
    {
        Console.WriteLine(numberC);
    }
    else
    {
    Console.WriteLine(numberB);
    }
}
else
{
     if(numberC > numberA)
    {
        Console.WriteLine(numberC);
    }
    else
    {
    Console.WriteLine(numberA);
    }
}
