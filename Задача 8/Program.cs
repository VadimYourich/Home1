// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int i = 2;

if(number == 1)
{
    Console.WriteLine("Нет чётных чисел в заданном интервале!");
}
else
{
    if(number < 2)
    {
        Console.WriteLine("Чётные числа от " + number + " до 1:");
        while (number < i)
        {
            if(number % 2 == 0)
            { 
                Console.Write(number);
                if(number < i - 2)
                {
                    Console.Write(", ");
                }
            }
            number = number + 1;  
        }
    }
    else
    {
        Console.WriteLine("Чётные числа от 1 до " + number + ":");
        while (i <= number)
        {
            Console.Write(i);
                if(i < number - 1)
                {
                    Console.Write(", ");
                }
            i = i + 2;       
        }
    }
}
