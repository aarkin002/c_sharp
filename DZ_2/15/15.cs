Console.WriteLine("Введите день недели от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0} - День недели выходной? : {1}", a, a == 6 | a == 7 ? "ДА": "НЕТ");пше 