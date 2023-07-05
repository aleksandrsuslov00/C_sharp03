/*
 Напишите программу, которая принимает на вход координаты
 точки (Х и Y), причем Х и Y не равны 0, и выдает номер четверти 
 плоскости, в которой находится эта точка.

x=34; y=-30 -> 2 //4
x=2; y=4 -> 1
x=-34; y=-30 -> 3
*/

int GetNumberOfQuarter(int X, int Y)
{
    int result = 0;
    if (X > 0 && Y > 0)
    {
        result = 1;
    }
    
    else if (X < 0 && Y > 0)
    {
        result = 2;
    }
    
    else if (X < 0 && Y < 0)
    {
        result = 3;
    }
    
    else if (X > 0 && Y < 0)
    {
        result = 4;
    }

    return result;  
}

Console.WriteLine("Введите переменную Х ");
int user_X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную Y ");
int user_Y = Convert.ToInt32(Console.ReadLine());

int quarter = GetNumberOfQuarter(user_X, user_Y);
if (quarter > 0)
{
    Console.WriteLine($"Точка [{user_X} : {user_Y}] находится в {quarter} плоскости");
}
else 
{
    Console.WriteLine($"Точка [{user_X} : {user_Y}] находится на пересечении плоскостей");  
}




