/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число ");

int number = Convert.ToInt32(Console.ReadLine());

string index = Convert.ToString(number);

void PalindromeCheck(string index)
{
    if (index[0] == index[4] && index[1] == index[3])
    {
        Console.WriteLine($"Да, число {number} палиндром.");
    }

    else 
    {
        Console.WriteLine($"Нет, число {number} не палиндром.");
    }
}

if (index.Length > 5 || index.Length < 5)
    {
        Console.WriteLine("Введено не пятизначное число");
        return;
    }
else PalindromeCheck(index);
