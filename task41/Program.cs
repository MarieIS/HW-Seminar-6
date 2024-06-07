// See https://aka.ms/new-console-template for more information

int GetCountAmount(int length)
{
   int counter = 0;
   for (int i = 0; i < length; i++)
   {
      Console.Write("Введите ваше "+(i+1)+" целое число: ");
      int user_input = Convert.ToInt32(Console.ReadLine());
      if (user_input > 0) 
      {
         counter++;
      }
   }
   return counter;
}

int GetNumberAmount(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetNumberAmount("Введите желаемое количество чисел: ");
int count = GetCountAmount(number);
Console.WriteLine($"Количество положительных чисел равно: {count}");