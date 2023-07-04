Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = int.Parse(Console.ReadLine());
int c = 1;
for(int i = 1; i <= b; i++){
    c *= a;
};
Console.WriteLine("{0} в степени {1} == {2}: ", a, b, c);