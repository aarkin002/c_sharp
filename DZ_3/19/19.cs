Console.WriteLine("Введите Пятизначное число: ");
string a = Console.ReadLine();
char[] arr = a.ToCharArray();
Array.Reverse(arr);
string areverse = new String(arr);
Console.WriteLine("{1} - палиндром?  -  {0}", a == areverse ? "ДА": "НЕТ", a);