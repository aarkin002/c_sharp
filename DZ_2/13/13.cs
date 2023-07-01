Console.WriteLine("Введите а: ");
string a = Console.ReadLine();
Console.WriteLine("Третья цифра: {0}", a.Length > 2 ? a.ToArray()[2]: "третьей цифры нет");