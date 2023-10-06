// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Введите коэффициент k1:");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициент k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Точки пересечения нет, прямые параллельны");
}
else
{
    Console.WriteLine("Введите коэффициент b1:");
    int b1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите коэффициент b2:");
    int b2 = Convert.ToInt32(Console.ReadLine());

    double[] crossPoint = CalcCrossPoint(k1, k2, b1, b2);

    Console.WriteLine($"Точка пересечения: ({crossPoint[0]:f1} , {crossPoint[1]:f1})");
}

// Methods

static double[] CalcCrossPoint(double k1, double k2, double b1, double b2)
{
    double[] point = new double[2];

    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k2 * (b2 - b1) / (k1 - k2) + b2;

    return point;
}