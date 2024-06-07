// See https://aka.ms/new-console-template for more information
float GetY(int coeff_k, int coeff_b, float x_coord)
{
   return (coeff_k * x_coord + coeff_b);
}

float GetX(int coeff_k1, int coeff_b1, int coeff_k2, int coeff_b2) /*k1x+b1=k2x+b2*/
{
   return (coeff_b2 - coeff_b1) / (coeff_k1 - coeff_k2);
}

int GetNumberAmount(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int k1 = GetNumberAmount("Введите коэффициент k1: ");
int b1 = GetNumberAmount("Введите коэффициент b1: ");
int k2 = GetNumberAmount("Введите коэффициент k2: ");
int b2 = GetNumberAmount("Введите коэффициент b2: ");
float x = GetX(k1, b1, k2, b2);
float y = GetY(k1, b1, x);
Console.WriteLine($"Координаты точки пересечения двух прямых: {x} и {y}");