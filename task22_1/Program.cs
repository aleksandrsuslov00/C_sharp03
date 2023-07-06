/* 
Напишите программу, которая принимает на вход число N 
и выдает таблицу квадратов чисел от 1 до N.

5 -> 1^(1) 2^(4) 3^(9) 4^(16) 5^(25)

*/

string Squares(int n)
{
    string squares = "1";
    if (n > 2)
    {
        for (int i = 2; i <= n; i++)
        {
            squares = $"{squares} {i * i}";
        }
    }
    
    else 
    {
       for (int i = 0; i >= n; i--)
        {
            squares = $"{squares} {i * i}";
        } 
    }
    return squares;
}

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(Squares(number));
