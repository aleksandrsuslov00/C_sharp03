/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 0;
int cube = 0;

if (number > 0)
{
    while (index < number + 1)
    {
        cube = index * index * index;
        index = index + 1;
        Console.Write($"{cube}, ");
    } 
} 

else 
{
    index = index * (-1); 
    while (index > number - 1)
    {
        cube = index * index * index;
        index = index - 1;
        Console.Write($"{cube}, ");
    }
}
