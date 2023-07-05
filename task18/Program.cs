/* Напишите программу, которая по заданному номеру четерти,
показывает диапазон возможных координат точек в этой четверти (х и у).
*/
Console.WriteLine("Введите номер четверти ");
int user_quarter_number = Convert.ToInt32(Console.ReadLine());

void GetRangeOfPossibleCoordinates(int quarter_number)
{
    if (quarter_number == 1)
    {
        Console.WriteLine("Первая четверть, x > 0, y > 0");
    }
    else if (quarter_number == 2)
    {
        Console.WriteLine("Вторая четверть, x < 0, y > 0");
    }
    else if (quarter_number == 3) 
    {
        Console.WriteLine("Третья четверть, x < 0, y < 0");
    }
    else if (quarter_number == 4) 
    {
        Console.WriteLine("Четвертая четверть, x > 0, y < 0");
    }
    else if (quarter_number < 1 || quarter_number > 4) 
    {
        Console.WriteLine("Неправильный номер четверти");
    }
}
GetRangeOfPossibleCoordinates(user_quarter_number);
