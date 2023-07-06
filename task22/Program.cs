/*
Напишите программу, которая принимает на вход число N 
и выдает таблицу квадратов чисел от 1 до N.

5 -> 1^(1) 2^(4) 3^(9) 4^(16) 5^(25)

*/

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
int mult = 0;

if (number > 0)
{
    while (count < number + 1)
    {
        mult = count * count;
        count = count + 1;
        Console.Write($"{mult}, ");
    }
}

else 
{
   count = count * (-1);
   while (count > number - 1)
    {
        mult = count * count;
        count = count - 1;
        Console.Write($"{mult}, ");
    } 
}

