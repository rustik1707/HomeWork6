/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


double Getnumber(string message)
{
    double result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.WriteLine(message);    
        if(double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
    
        else 
        {
            Console.WriteLine("ввели некорректную команду");
        }
    }
    return result;

}
double CoordinateX(double b1, double k1, double b2, double k2)
{   
    double x = (b2-b1)/(k1-k2);
    
    return x;
    

}
double CoordinateY(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x+b1;
    return y;
}


double b1 = Getnumber("введите b1:");
double k1 = Getnumber("введите k1:");
double b2 = Getnumber("введите b2:");
double k2 = Getnumber("введите k2:");

double x = CoordinateX(b1,k1,b2,k2);
double y = CoordinateY(b1,k1,b2,k2);
Console.WriteLine($"координаты точки пересечения прямых равна({x},{y})");