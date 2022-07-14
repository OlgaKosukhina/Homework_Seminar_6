/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.
Значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

int GetNumber()
{
    int result = 0;

    while(true)
    {
        Console.WriteLine("Insert number:");

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You input not a number. Please input correct number.");
        }
    }
    return result;
}

(double, double) GetPointOfIntersection(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1) / (k1 - k2)) + b1;

    return (x, y);
}


double b1 = GetNumber();
double k1 = GetNumber();
double b2 = GetNumber();
double k2 = GetNumber();
(double x, double y) = GetPointOfIntersection(b1, k1, b2, k2);
Console.WriteLine($"The point of intersection has coordinates ({x};{y})");