// Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

double b1 = Convert.ToDouble(DataEntry("Введите b1: "));
double k1= Convert.ToDouble(DataEntry("Введите k1: "));
double b2 = Convert.ToDouble(DataEntry("Введите b2: "));
double k2 = Convert.ToDouble(DataEntry("Введите b2: "));
double x = (b1-b2)/(k2-k1);
double y = k1*x+b1;
Console.WriteLine($"Прямые пересекаются в точке ({x}; {y})");
