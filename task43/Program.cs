// See https://aka.ms/new-console-template for more information
void GetCountAmount(int length)
{
   int count = 0;
   for (int i = 0; i < length; i++)
   {
      Console.Write("Введите ваше "+(i+1)+" целое число: ");
      int user_input = Convert.ToInt32(Console.ReadLine());
      if (user_input > 0) 
      {
         count++;
      }
   }
   Console.WriteLine($"Количество положительных чисел равно: {count}");
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
GetCountAmount(number);