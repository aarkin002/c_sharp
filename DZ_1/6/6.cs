Console.WriteLine("Введите а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{1} - Четное?: {0}" , a % 2 == 0 ? "ДА":"НЕТ", a);